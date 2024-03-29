﻿namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestStatičkogKonstruktora : ConsoleTest
    {
        static bool pozvanStatičkiKonstruktorBazneKlase = false;

        [TestMethod]
        public void PrijePozivaStatičkeMetodeIzvodiSeStatičkiKonstruktor()
        {
            StatičkiKonstruktor.PozoviSamoStatičkuMetodu();
            if (!pozvanStatičkiKonstruktorBazneKlase)
            {
                Assert.AreEqual("SaStatičkimKonstruktorom1.StatičkiKonstruktor", cw?.GetString());
                pozvanStatičkiKonstruktorBazneKlase = true;
            }
            Assert.AreEqual("SaStatičkimKonstruktorom1.Metoda1", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PrijeStvaranjaObjektaIzvodiSeStatičkiKonstruktor()
        {
            StatičkiKonstruktor.PozoviNestatičkuMetodu();
            Assert.AreEqual("SaStatičkimKonstruktorom2.StatičkiKonstruktor", cw?.GetString());

            if (!pozvanStatičkiKonstruktorBazneKlase)
            {
                Assert.AreEqual("SaStatičkimKonstruktorom1.StatičkiKonstruktor", cw?.GetString());
                pozvanStatičkiKonstruktorBazneKlase = true;
            }
            Assert.AreEqual("SaStatičkimKonstruktorom1.KonstruktorKlase", cw?.GetString());
            Assert.AreEqual("SaStatičkimKonstruktorom2.KonstruktorKlase", cw?.GetString());
            Assert.AreEqual("SaStatičkimKonstruktorom2.Metoda2", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }
    }
}
