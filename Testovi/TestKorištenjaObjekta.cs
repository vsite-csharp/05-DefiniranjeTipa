using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    class VremenskiInterval
    {
        public void Zaključi()
        {
            this.završniTrenutak = DateTime.Now;
        }

        public bool JeLiTrenutakIzIntervala(DateTime trenutak)
        {
            Zaključi();
            return trenutak >= početniTrenutak && trenutak <= završniTrenutak;
        }

        public bool JeLiDatumIzIntervala(DateTime datum)
        {
            Zaključi();
            return datum >= početniTrenutak.Date && datum <= završniTrenutak.Date;
        }

        public bool JeLiVrijemeUDanuUMinutamaIzIntervala(DateTime vrijemeUMinutama)
        {
            Zaključi();
            return vrijemeUMinutama >= početniTrenutak.AddMinutes(-1) && vrijemeUMinutama <= završniTrenutak;
        }

        private DateTime početniTrenutak = DateTime.Now;
        private DateTime završniTrenutak;
    }

    [TestClass]
    public class TestKorištenjaObjekta : ConsoleTest
    {
        [TestMethod]
        public void KorištenjeObjekta_IspišiTrenutniDatumVrijemeIspisujeTrenutnuVrijednost()
        {
            VremenskiInterval vi = new VremenskiInterval();
            KorištenjeObjekata.IspišiTrenutniDatumVrijeme();

            Assert.IsFalse(cw.IsEmpty);
            object obj = cw.GetObject();
            string ispisano = obj as string;
            DateTime ispisanoVrijeme = ispisano != null ? DateTime.Parse(ispisano) : (DateTime)obj;
            Assert.IsTrue(vi.JeLiTrenutakIzIntervala(ispisanoVrijeme));
        }

        [TestMethod]
        public void KorištenjeObjekta_IspišiDanašnjiDatumIspisujeDanašnjiDatum()
        {
            VremenskiInterval vi = new VremenskiInterval();
            KorištenjeObjekata.IspišiDanašnjiDatum();

            Assert.IsFalse(cw.IsEmpty);
            DateTime ispisaniDatum = DateTime.ParseExact(cw.GetString(), CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern, CultureInfo.CurrentCulture);
            Assert.IsTrue(vi.JeLiDatumIzIntervala(ispisaniDatum));
        }

        [TestMethod]
        public void KorištenjeObjekta_IspišiTrenutnoVrijemeIspisujeVrijednost()
        {
            VremenskiInterval vi = new VremenskiInterval();
            KorištenjeObjekata.IspišiTrenutnoVrijeme();

            Assert.IsFalse(cw.IsEmpty);
            DateTime ispisanoVrijeme = DateTime.ParseExact(cw.GetString(), CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern, CultureInfo.CurrentCulture);
            Assert.IsTrue(vi.JeLiVrijemeUDanuUMinutamaIzIntervala(ispisanoVrijeme));
        }

        [TestMethod]
        public void KorištenjeObjekta_IzračunajBrojDanaIzmeđuDvaDatumaVraća365ZaNeprestupnuGodinu()
        {
            Assert.AreEqual(365, KorištenjeObjekata.IzračunajBrojDanaIzmeđuDvaDatuma(2001, 1, 1, 2002, 1, 1));
        }

        [TestMethod]
        public void KorištenjeObjekta_IzračunajBrojDanaIzmeđuDvaDatumaVraća366ZaPrestupnuGodinu()
        {
            Assert.AreEqual(366, KorištenjeObjekata.IzračunajBrojDanaIzmeđuDvaDatuma(2004, 1, 1, 2005, 1, 1));
        }
    }
}
