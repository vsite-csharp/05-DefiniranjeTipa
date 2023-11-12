namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestDefinicijeTipa : ConsoleTest
    {
        [TestMethod]
        public void MojaKlasaIspišiČlanIspisuje5()
        {
            DefinicijaTipa.IspišiČlanKlase();
            Assert.AreEqual(5, cw?.GetInt());
        }

        [TestMethod]
        public void MojaStrukturaIspišiČlanIspisujeMojaStruktura()
        {
            DefinicijaTipa.IspišiČlanStrukture();
            Assert.AreEqual("MojaStruktura", cw?.GetString());
        }
    }
}
