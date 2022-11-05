using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

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
        public void IzvedenaIzInterneBazneIspišiMePozivaMetoduIzInterneBazne()
        {
            IzvedenaIzInterneBazne izvedanaIzInterneBazne = new IzvedenaIzInterneBazne();

            var metoda = izvedanaIzInterneBazne.GetType().GetMethod("IspišiMe", BindingFlags.Public | BindingFlags.Instance);
            Assert.IsNotNull(metoda);
            metoda.Invoke(izvedanaIzInterneBazne, new object[] { });

            Assert.AreEqual("InternaBazna", cw.GetString());
        }
    }
}
