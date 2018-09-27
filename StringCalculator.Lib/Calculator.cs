using System.Linq;

namespace StringCalculator.Lib
{
    public class Calculator
    {
        private INumberParser parser;
        private readonly INumberValidator numberValidator;
        private readonly IParserFactory parserFactory;

        private const int MaxNumber = 1000;

        public Calculator(IParserFactory parserFactory, INumberValidator numberValidator)
        {
            this.numberValidator = numberValidator;
            this.parserFactory = parserFactory;
        }

        public int Add(string input)
        {
            parser = parserFactory.Create(input);

            var numbers = parser.Parse(input).Where(x => x <= MaxNumber);

            numberValidator.Validate(numbers);

            return numbers.Sum();
        }
    }
}