using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{
    public class ExplicitDelimiterParser : INumberParser
    {
        public IEnumerable<int> Parse(string input)
        {
            var delimiter = input[2];

            return input.Substring(4)
                .Split(delimiter)
                .Select(x => int.Parse(x));
        }
    }
}