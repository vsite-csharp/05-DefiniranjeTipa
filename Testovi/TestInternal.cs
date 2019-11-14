using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestInternal : ConsoleTest
    {
        [TestMethod]
        public void IzvedenaIzJavneBazne_IspišiMePozivaMetoduUBaznojKlasi()
        {
            Internal.IspišiIzvedenuIzJavne();
            Assert.AreEqual("JavnaBazna", cw.GetString());
        }

        [TestMethod]
        public void IzvedenaIzBazne_IspišiMePozivaMetoduUBaznojKlasi()
        {
            Internal.IspišiIzvedenuIzBazne();
            Assert.AreEqual("???Bazna", cw.GetString());
        }

        [TestMethod]
        public void IzvedenaIzInterneBazneLokalneIspišiMePozivaMetoduUBaznojKlasi()
        {
            IzvedenaIzInterneBazne izvedanaIzInterneBazne = new IzvedenaIzInterneBazne();
            izvedanaIzInterneBazne.IspišiMe();
            Assert.AreEqual("InternaBazna", cw.GetString());
        }
    }
}
