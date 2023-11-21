namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestKonstruktoraKlase : ConsoleTest
    {
        [TestMethod]
        public void KonstruktorSArgumentimaInicijaliziraOsobu()
        {
            KonstruktorKlase.StvoriObjektZadanimKonstruktorom(ime: "Nikola", prezime: "Tesla", datumRođenja: new DateTime(1856, 7, 10));
            Assert.IsTrue(cw?.GetString()?.EndsWith("Nikola"));
            Assert.IsTrue(cw?.GetString()?.EndsWith("Tesla"));
            Assert.AreEqual(expected: new DateTime(1856, 7, 10), (DateTime)cw?.GetObject()!);
        }
    }
}
