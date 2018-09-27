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
            var delimiter = input.Substring(startPosition, endPosition - startPosition);

            input = input.Substring(endPosition + 2);

            return input
                .Split(new[] { delimiter }, StringSplitOptions.None)
                .Select((x) => int.Parse(x));
        }
    }
}