using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CI_Test;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCalc
    {
        Calculator calc;

        [TestInitialize]
        public void setup() 
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestAdd()
        {
            int x = 5;
            int y = 7;

            int z = calc.Add(x, y);

            Assert.AreEqual(x + y, z);
        }

        [TestMethod]
        public void TestMultiply() 
        {
            int x = 5;
            int y = 7;

            int z = calc.Multiply(x, y);

            Assert.AreEqual(x * y, z);
        }
    }
}
