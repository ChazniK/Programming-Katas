using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalc;

namespace StringCalcTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_WhenEmptyString_ShouldReturnZero()
        { 
            //------------Arrange-----------------
            var input = "";
            var calculator = new StringCalculator();

            //------------Act-----------------
            var result = calculator.add(input);

            //------------Assert-----------------
            var expected = 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_WhenStringHasOneValue_ShouldReturnValue()
        {
            //------------Arrange-----------------
            var input = "22";
            var calculator = new StringCalculator();

            //------------Act-----------------
            var result = calculator.add(input);

            //------------Assert-----------------
            var expected = 22;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]

        public void Add_WhenStringHasTwoValues_ShouldReturnSumOfValues()
        {
            //------------Arrange-----------------
            var input = "1,2";
            var calculator = new StringCalculator();

            //------------Act-----------------
            var result = calculator.add(input);

            //------------Assert-----------------
            var expected = 3;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_WhenUnknowAmountOfValues_ShouldReturnSumOfValues()
        {
            //------------Arrange-----------------
            var input = "1,2,3";
            var calculator = new StringCalculator();

            //------------Act---------------------
            var result = calculator.add(input);

            //------------Assert-----------------
            var expected = 6;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Add_WhenThereAreCommasAndNewLines_ShouldReturnSumOfValues()
        {
            //------------Arrange-----------------
            var input = "5,\n";
            var calculator = new StringCalculator();

            //------------Act---------------------
            var result = calculator.add(input);

            //------------Assert-----------------
            var expected = 5;
            Assert.AreEqual(expected, result);
        }
    }
}
