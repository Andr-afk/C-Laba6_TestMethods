using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace ClassesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaxValue()
        {
            Assert.AreEqual(String.Join(", ", new double[] { 89, 4, 1 }), Class1.MaxValue(4, 1, 89));
        }

        [TestMethod]
        public void Divider()
        {
            Assert.AreEqual(2, Class1.Divider(10, 2));
            Assert.AreEqual(3, Class1.Divider(78, 9));
            Assert.AreEqual(4, Class1.Divider(124, 32));
        }

        [TestMethod]
        public void sumRank()
        {
            Assert.AreEqual(24, Class1.SumRank(1234));
            Assert.AreEqual(86, Class1.SumRank(9876));
            Assert.AreEqual(42, Class1.SumRank(354792));
        }

        [TestMethod]
        public void matrix()
        {
            Assert.AreEqual(8, Class1.matrix(new double[,] { { 2, 3, 2 }, { 4, 7, 3 } }));
        }
    }
}
