using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FirstOrDefault;

namespace FirstOrDefault_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            //Assert.AreEqual(null, MyClass.FirstOrDefault(new string[0], x => true)); // default(string) == null
            Assert.AreEqual("1 2", MyClass.take(new[] { 1, 2, 3, 4 }, 2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Assert.AreEqual(3, MyClass.FirstOrDefault(new[] { 1, 2, 3 }, x => x > 2));
            Assert.AreEqual("1 2", MyClass.take(new[] { 1, 2, 3, 4 }, 2));
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Assert.AreEqual(3, MyClass.FirstOrDefault(new[] { 3, 2, 1 }, x => x > 2));
            Assert.AreEqual("1 2", MyClass.take(new[] { 1, 2, 3, 4 }, 2));
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Assert.AreEqual(3, MyClass.FirstOrDefault(new[] { 2, 3, 1 }, x => x > 2));
            Assert.AreEqual("1 2", MyClass.take(new[] { 1, 2, 3, 4 }, 2));
        }
    }
}
