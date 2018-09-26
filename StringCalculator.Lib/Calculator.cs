using System.Linq;

namespace StringCalculator.Lib
{
    public partial class Calculator
    {
        private INumberParser parser;
        private INumberValidator numberValidator;
        private readonly IParserFactory parserFactory;

        public Calculator(IParserFactory parserFactory, INumberValidator numberValidator)
        {
            this.numberValidator = numberValidator;
            this.parserFactory = parserFactory;
        }

        public int Add(string input)
        {
            parser = parserFactory.Create(input);

            var numbers = parser.Parse(input);

            numberValidator.Validate(numbers);

            return numbers.Sum();
        }
    }
}