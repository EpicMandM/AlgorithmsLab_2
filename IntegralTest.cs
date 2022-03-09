using System;
using NUnit.Framework;


namespace AlgorithmsLab_2
{
    [TestFixture]
    class IntegralTest
    {
        static Func<double, double> func = t => t != 1 ? Math.Log(t) / (1 - Math.Pow(t, 2)) : 0;
        [Test]
        public static void LeftSquareTest()
        {
            IIntegral integral = new LeftIntegral();
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.1, 10e4), 0, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.2, 10e4), -0.1960, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.3, 10e4), -0.3446, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.4, 10e4), -0.4646, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.5, 10e4), -0.5649, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.6, 10e4), -0.6507, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.7, 10e4), -0.7254, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.8, 10e4), -0.7912, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.9, 10e4), -0.8499, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 1, 10e4), -0.9025, 0.01);

        }
        [Test]
        public static void RightSquareTest()
        {
            IIntegral integral = new RightIntegral();
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.1, 10e4), 0, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.2, 10e4), -0.1960, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.3, 10e4), -0.3446, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.4, 10e4), -0.4646, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.5, 10e4), -0.5649, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.6, 10e4), -0.6507, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.7, 10e4), -0.7254, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.8, 10e4), -0.7912, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.9, 10e4), -0.8499, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 1, 10e4), -0.9025, 0.01);
        }
        [Test]
        public static void MiddleSquareTest()
        {
            IIntegral integral = new MiddleIntegral();
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.1, 10e4), 0, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.2, 10e4), -0.1960, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.3, 10e4), -0.3446, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.4, 10e4), -0.4646, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.5, 10e4), -0.5649, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.6, 10e4), -0.6507, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.7, 10e4), -0.7254, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.8, 10e4), -0.7912, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 0.9, 10e4), -0.8499, 0.01);
            Assert.AreEqual(integral.GetIntegral(func, 0.1, 1, 10e4), -0.9025, 0.01);
        }

    }
}
