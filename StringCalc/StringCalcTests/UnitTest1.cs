using System;
using System.Collections.Generic;
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
            var input = "1,2,3,4";
            var calculator = new StringCalculator();

            //------------Act---------------------
            var result = calculator.add(input);

            //------------Assert-----------------
            var expected = 10;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Add_WhenThereAreCommasAndNewLines_ShouldReturnSumOfValues()
        {
            //------------Arrange-----------------
            var input = "1\n5\n\n4";
            var calculator = new StringCalculator();

            //------------Act---------------------
            var result = calculator.add(input);

            //------------Assert-----------------
            var expected = 10;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_WhenTheAreCustomDelimiters_ShouldReturnSumOfTheValues()
        {
            //------------Arrange-----------------
            var input = "//;\n1;2";
            var calculator = new StringCalculator();

            //------------Act---------------------
            var result = calculator.add(input);

            //------------Assert-----------------
            var expected = 3;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_WhenNegativeNumber_ShouldThrowExceptionWithNegative()
        {
            var input = "-1";
            var calculator = new StringCalculator();

            //------------Act---------------------
            var result = Assert.ThrowsException<Exception>(() => calculator.add(input));

            //------------Assert-----------------
            var expected = "negatives not allowed: -1";
            Assert.AreEqual(expected, result.Message);
        }

        [TestMethod]
        public void Add_WhenNegativeNumbers_ShouldThrowExceptionWithAllNegatives()
        {
            var input = "//;\n1;-1;-3;-9";
            var calculator = new StringCalculator();

            //------------Act---------------------
            var result = Assert.ThrowsException<Exception>(() => calculator.add(input));

            //------------Assert-----------------
            var expected = "negatives not allowed: -1,-3,-9";
            Assert.AreEqual(expected, result.Message);
        } 
    }
}
