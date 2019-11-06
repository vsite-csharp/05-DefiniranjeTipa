using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestDelegiranjaKonstruktora : ConsoleTest
    {

        [TestMethod]
        public void DelegiranjeKonstruktora_PozivKonstruktoraSDvaArgumenta()
        {
            DelegiranjeKonstruktora.StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);
            Assert.AreEqual("Bazna.Bazna(5)", cw.GetString());
            Assert.AreEqual("Izvedena.Izvedena(5, 7)", cw.GetString());
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(7, cw.GetInt());
        }

        [TestMethod]
        public void DelegiranjeKonstruktora_PozivKonstruktoraSJednimArgumentom()
        {
            DelegiranjeKonstruktora.StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(5);
            Assert.AreEqual("Bazna.Bazna(5)", cw.GetString());
            Assert.AreEqual("Izvedena.Izvedena(5, 0)", cw.GetString());
            Assert.AreEqual("Izvedena.Izvedena(5)", cw.GetString());
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(0, cw.GetInt());
        }

    }
}
