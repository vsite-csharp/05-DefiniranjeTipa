using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp.StatičkiČlanovi;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestStatičkihČlanova : ConsoleTest
    {
        [TestMethod]
        public void StatičkiČlanovi_IspišiBrojStvorenihObjekataIspisujeBrojStvorenihObjekata()
        {
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            int brojObjekata = cw.GetInt();

            BrojačInstanci bi = new BrojačInstanci();
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            Assert.AreEqual(++brojObjekata, cw.GetInt());

            bi = new BrojačInstanci();
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            Assert.AreEqual(++brojObjekata, cw.GetInt());
        }

        [TestMethod]
        public void StatičkiČlanovi_IspišiRedniBrojObjektaIspisujeRedniBroj()
        {
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            int brojObjekata = cw.GetInt();

            BrojačInstanci bi = new BrojačInstanci();
            bi.IspišiRedniBrojObjekta();
            Assert.AreEqual(++brojObjekata, cw.GetInt());

            bi = new BrojačInstanci();
            bi.IspišiRedniBrojObjekta();
            Assert.AreEqual(++brojObjekata, cw.GetInt());
        }
    }
}
