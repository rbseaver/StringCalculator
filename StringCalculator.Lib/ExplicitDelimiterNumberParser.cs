using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{
    public class ExplicitDelimiterNumberParser : INumberParser
    {
        private const int DelimiterPosition = 2;
        private const int NumberStartIndex = 4;

        public IEnumerable<int> Parse(string input)
        {
            var delimiter = input[DelimiterPosition];

            return input.Substring(NumberStartIndex)
                .Split(delimiter)
                .Select(x => int.Parse(x));
        }
    }
}