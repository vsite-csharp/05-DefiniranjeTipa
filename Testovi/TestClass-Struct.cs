namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public class TestClass_Struct : ConsoleTest
    {
        [TestMethod]
        public void IspišiKlase()
        {
            ClassStruct.IspišiKlase();
            Assert.AreEqual(5, cw?.GetInt());
            Assert.AreEqual(5, cw?.GetInt());

            Assert.AreEqual(2, cw?.GetInt());
            Assert.AreEqual(2, cw?.GetInt());
        }

        [TestMethod]
        public void IspišiStrukture()
        {
            ClassStruct.IspišiStrukture();
            Assert.AreEqual("MojaStruktura", cw?.GetString());
            Assert.AreEqual("MojaStruktura", cw?.GetString());

            Assert.AreEqual("MojaStruktura", cw?.GetString());
            Assert.AreEqual("MyStruct", cw?.GetString());
        }
    }
}
