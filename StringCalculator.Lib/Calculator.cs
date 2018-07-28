using System;
using System.Linq;
using System.Runtime.Serialization;

namespace StringCalculator.Lib
{
    public class Calculator
    {
        private const int DefaultValue = 0;

        private INumberParser _numberParser;
        private IDelimiterParser _delimiterParser;
        private readonly INumberValidator _validator;

        public Calculator(INumberValidator validator)
        {
            _validator = validator;
        }

        public int Add(string input)
        {
            if (input.Length == 0)
            {
                return DefaultValue;
            }

            var customMarker = input.StartsWith("//");
            _delimiterParser = DelimiterParserFactory.Create(customMarker);
            _numberParser = NumberParserFactory.Create(customMarker);

            var delimiters = _delimiterParser.Parse(input);

            var numbers = _numberParser.Parse(input, delimiters);

            _validator.Validate(numbers);

            return numbers.Sum();
        }
    }
}