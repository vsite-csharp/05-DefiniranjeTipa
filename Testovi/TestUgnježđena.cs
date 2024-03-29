﻿namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestUgnježđena : ConsoleTest
    {
        [TestMethod]
        public void Gnijezdo_IspišiSeIspisujeZadaniTekst()
        {
            Gnijezdo g = new Gnijezdo();
            g.IspišiMe();
            Assert.AreEqual("Ugnježđena", cw?.GetString());
            
        }

        [TestMethod]
        public void IzvedenoGnijezdo_PredstaviSeIspisujeZadaniTekst()
        {
            IzvedenoGnijezdo ig = new IzvedenoGnijezdo();
            ig.PredstaviSe();
            Assert.AreEqual("Ja sam klasa Ugnježđena", cw?.GetString());
        }

        [TestMethod]
        public void IzravnoKorištenjeUgnježđeneKlase()
        {
            UgnježđenaKlasa.IzravnoKorištenjeUgnježđeneKlase();
            Assert.AreEqual("Ja sam klasa Ugnježđena, neposredno", cw?.GetString());
        }
    }
}
