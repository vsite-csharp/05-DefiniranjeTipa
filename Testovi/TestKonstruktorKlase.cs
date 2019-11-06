using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestKonstruktorKlase : ConsoleTest
    {
        [TestMethod]
        public void KonstruktorSArgumentimaInicijaliziraOsobu()
        {
            KonstruktorKlase.StvoriObjektZadanimKonstruktorom("Nikola", "Tesla", new DateTime(1856, 7, 10));
            Assert.AreEqual("Nikola", cw.GetString());
            Assert.AreEqual("Tesla", cw.GetString());
            Assert.AreEqual(new DateTime(1856, 7, 10), (DateTime)cw.GetObject());
        }
    }
}
