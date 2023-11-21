namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestDelegiranjaKonstruktora : ConsoleTest
    {

        [TestMethod]
        public void PozivKonstruktoraSDvaArgumenta()
        {
            DelegiranjeKonstruktora.StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);
            Assert.AreEqual("Bazna.Bazna(a: 5)", cw?.GetString());
            Assert.AreEqual("Izvedena.Izvedena(a: 5, b: 7)", cw?.GetString());
            Assert.AreEqual(5, cw?.GetInt());
            Assert.AreEqual(7, cw?.GetInt());
        }

        [TestMethod]
        public void PozivKonstruktoraSJednimArgumentom()
        {
            DelegiranjeKonstruktora.StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(5);
            Assert.AreEqual("Bazna.Bazna(a: 5)", cw?.GetString());
            Assert.AreEqual("Izvedena.Izvedena(a: 5, b: 0)", cw?.GetString());
            Assert.AreEqual("Izvedena.Izvedena(a: 5)", cw?.GetString());
            Assert.AreEqual(5, cw?.GetInt());
            Assert.AreEqual(0, cw?.GetInt());
        }

    }
}
