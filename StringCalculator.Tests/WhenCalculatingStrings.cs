using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator.Lib;

namespace StringCalculator.Tests
{
    [TestClass]
    public class WhenCalculatingStrings
    {
        [TestMethod]
        public void ItShouldReturnZeroForEmptyString()
        {
            var calculator = InitializeCalculator();
            const int expected = 0;
            var input = string.Empty;

            int actual = calculator.Add(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("1", 1)]
        [DataRow("3", 3)]
        public void AndSingleNumberItShouldReturnThatNumber(string input, int expected)
        {
            var calculator = InitializeCalculator();

            var result = calculator.Add(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("1,1", 2)]
        [DataRow("1,2", 3)]
        public void ItShouldAddMultipleNumbers(string input, int expected)
        {
            var calculator = InitializeCalculator();

            var result = calculator.Add(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("1\n1", 2)]
        [DataRow("1\n2\n3", 6)]
        public void ItShouldAddMultipleNumbersWithNewlineDelimiter(string input, int expected)
        {
            var calculator = InitializeCalculator();

            var result = calculator.Add(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ItShouldAcceptExplicitDelimiter()
        {
            var calculator = InitializeCalculator();

            var result = calculator.Add("//;\n1;1");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ItShouldThrowExceptionForNegatives()
        {
            var calculator = InitializeCalculator();

            var exception = Assert.ThrowsException<NumberTypeException>(() => calculator.Add("1,-2,-3,1"));
            Assert.AreEqual("Negatives not allowed: -2,-3", exception.Message);
        }

        [TestMethod]
        [DataRow("1,2,1001,3", 6)]
        [DataRow("//;\n1;2;1001;3", 6)]
        public void ItShouldIgnoreNumbersOverOneThousand(string input, int expected)
        {
            var calculator = InitializeCalculator();

            var result = calculator.Add(input);

            Assert.AreEqual(expected, result);
        }

        private Calculator InitializeCalculator()
        {
            return new Calculator(new ParserFactory(), new PositiveNumberValidator());
        }
    }
}