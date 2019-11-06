using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestIDisposable
    {
        [TestMethod]
        public void DatotekaJeUspješnoObrisana()
        {
            string ime = "privremena.txt";
            Disposable.StvaranjeIPisanjeUDatoteku(ime);
            Assert.IsTrue(File.Exists(ime));
            Disposable.BrisanjeDatoteke(ime);
            Assert.IsFalse(File.Exists(ime));
        }
    }
}
