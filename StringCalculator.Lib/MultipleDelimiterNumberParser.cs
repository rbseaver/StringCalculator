using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{
    public class MultipleDelimiterNumberParser : INumberParser
    {
        public IEnumerable<int> Parse(string input)
        {
            var startPosition = input.IndexOf("[") + 1;
            var endPosition = input.IndexOf("]");

            var delimiter = ExtractDelimiter(input, startPosition, endPosition);

            input = input.Substring(endPosition + 2);

            return input
                .Split(new[] { delimiter }, StringSplitOptions.None)
                .Select((x) => int.Parse(x));
        }

        private string ExtractDelimiter(string input, int startPosition, int endPosition)
        {
            return input.Substring(startPosition, endPosition - startPosition);
        }
    }
}