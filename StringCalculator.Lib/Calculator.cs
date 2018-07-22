using System;
using System.Linq;
using System.Runtime.Serialization;

namespace StringCalculator.Lib
{
    public partial class Calculator
    {
        private const int DefaultValue = 0;
        private readonly NumberParser _numberParser;
        private IDelimiterParser _delimiterParser;
        private readonly INumberValidator _validator;

        public Calculator(
            NumberParser numberParser,
            INumberValidator validator
            )
        {
            _numberParser = numberParser;
            _validator = validator;
        }

        public int Add(string input)
        {
            var customMarker = input.StartsWith("//");
            _delimiterParser = DelimiterParserFactory.Create(customMarker);

            if (input.Length == 0)
            {
                return DefaultValue;
            }

            var delimiters = _delimiterParser.Parse(input);

            var numbers = _numberParser.Parse(input, delimiters);

            _validator.Validate(numbers);

            return numbers.Sum();
        }
    }
}