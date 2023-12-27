namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestIDisposable
    {
        [TestMethod]
        public void DatotekaSeMožeObrisatiNakonPozivaMetodeDispose()
        {
            var disposeMethod = typeof(KlasaSResursima).GetMethod("Dispose");
            Assert.IsNotNull(disposeMethod);

            string ime = "privremena.txt";

            var ks = new KlasaSResursima(ime);
            Assert.IsTrue(File.Exists(ime));

            disposeMethod.Invoke(ks, new object?[0] { });

            File.Delete(ime);
            Assert.IsFalse(File.Exists(ime));
        }

        [TestMethod]
        public void UpravljaniResursJeUspješnoUčitan()
        {
            var disposeMethod = typeof(KlasaSResursima).GetMethod("Dispose");
            Assert.IsNotNull(disposeMethod);

            string ime = "privremena.txt";
            var ks = new KlasaSResursima(ime);
            Assert.IsNotNull(ks.DajTekst());

            disposeMethod.Invoke(ks, new object?[0] { });

            File.Delete(ime);
            Assert.IsFalse(File.Exists(ime));
        }

        [TestMethod]
        public void UpravljaniResursJeUspješnoOslobođenPriNakonPozivaMetodeDispose()
        {
            var disposeMethod = typeof(KlasaSResursima).GetMethod("Dispose");
            Assert.IsNotNull(disposeMethod);

            string ime = "privremena.txt";
            var ks = new KlasaSResursima(ime);
            Assert.IsNotNull(ks.DajTekst());

            disposeMethod.Invoke(ks, new object?[0] { });
            Assert.IsNull(ks.DajTekst());

            File.Delete(ime);
            Assert.IsFalse(File.Exists(ime));
        }
    }
}
