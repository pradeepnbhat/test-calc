using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void AddTest1()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(6, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest2()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest3()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest4()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest5()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest6()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest7()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest8()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest9()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void AddTest10()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }
        
        [TestMethod]
        public void AddTest11()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(5, calc.Add(2, 3));
        }


        [TestMethod]
        public void SubTest()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(-1, calc.Sub(2, 3));
        }


        [TestMethod]
        public void MultTest()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(6, calc.Mult(2, 3));
        }

        [TestMethod]
        public void DivTest()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            Assert.AreEqual(2.5, calc.Div(5, 2));
        }
    }
}
