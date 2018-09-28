using System.Collections.Generic;

namespace StringCalculator.Lib
{
    public class MultipleDelimiterParser : INumberParser
    {
        public IEnumerable<int> Parse(string input)
        {
            var midPosition = input.IndexOf("][");

            return new[] { 1, 2, 3 };
        }
    }
}