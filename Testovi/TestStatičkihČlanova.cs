using Vsite.CSharp.StatičkiČlanovi;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestStatičkihČlanova : ConsoleTest
    {
        [TestMethod]
        public void IspišiBrojStvorenihObjekataIspisujeBrojStvorenihObjekata()
        {
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            int brojObjekata = cw!.GetInt();

            var bi = new BrojačInstanci();
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            Assert.AreEqual(++brojObjekata, cw.GetInt());

            bi = new BrojačInstanci();
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            Assert.AreEqual(++brojObjekata, cw.GetInt());
        }

        [TestMethod]
        public void IspišiRedniBrojObjektaIspisujeRedniBroj()
        {
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            int brojObjekata = cw!.GetInt();

            var bi = new BrojačInstanci();
            bi.IspišiRedniBrojObjekta();
            Assert.AreEqual(++brojObjekata, cw.GetInt());

            bi = new BrojačInstanci();
            bi.IspišiRedniBrojObjekta();
            Assert.AreEqual(++brojObjekata, cw.GetInt());
        }
    }
}
