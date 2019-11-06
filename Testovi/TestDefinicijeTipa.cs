using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestDefinicijeTipa : ConsoleTest
    {
        [TestMethod]
        public void DefinicijaTipa_MojaKlasaIspišiČlanIspisuje5()
        {
            DefinicijaTipa.IspišiČlanKlase();
            Assert.AreEqual(5, cw.GetInt());
        }

        [TestMethod]
        public void DefinicijaTipa_MojaStrukturaIspišiČlanIspisujeMojaStruktura()
        {
            DefinicijaTipa.IspišiČlanStrukture();
            Assert.AreEqual("MojaStruktura", cw.GetString());
        }
    }
}
