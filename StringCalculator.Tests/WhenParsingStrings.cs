using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator.Lib;

namespace StringCalculator.Tests
{
    [TestClass]
    public class WhenParsingStrings
    {
        [TestMethod]
        public void ItShouldReturnZeroForEmptyString()
        {
            Calculator calculator = MakeCalculator();
            var result = calculator.Add(string.Empty);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ItSholdReturnNumberForSingleNumbers()
        {
            Calculator calculator = MakeCalculator();
            var result = calculator.Add("1");
            Assert.AreEqual(1, result);
        }

        [DataTestMethod]
        [DataRow(2, "1,1")]
        [DataRow(4, "2,1,1")]
        [DataRow(19, "5,7,4,3")]
        public void ItShouldSumMoreThanOneNumber(int expected, string input)
        {
            var calculator = MakeCalculator();
            var result = calculator.Add(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(2, "1\n1")]
        [DataRow(4, "2\n1\n1")]
        [DataRow(19, "5\n7\n4\n3")]
        [DataRow(20, "5\n7,6,1\n1")]
        public void ItShouldAcceptNewlineDelimiter(int expected, string input)
        {
            var calculator = MakeCalculator();
            var result = calculator.Add(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ItShouldAcceptAnyDelimiter()
        {
            var calculator = MakeCalculator();
            var result = calculator.Add("//;\n1;1");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ItShouldThrowExceptionForNegativeNumbers()
        {
            var calculator = MakeCalculator();
            var exception = Assert.ThrowsException<NumberFormatException>(() => calculator.Add("-1,2,-3"));
            Assert.AreEqual("Negatives not allowed: -1, -3", exception.Message);
        }

        private static Calculator MakeCalculator()
        {
            return new Calculator(new PositiveNumberValidator());
        }
    }
}
