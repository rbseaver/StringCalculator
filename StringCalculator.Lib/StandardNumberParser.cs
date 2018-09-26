using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{

    public class StandardNumberParser : INumberParser
    {
        private IEnumerable<char> delimiters = new char[]
        {
            ',',
            '\n'
        };

        public IEnumerable<int> Parse(string input)
        {
            return input
                .Split(delimiters.ToArray())
                .Select(x => int.Parse(x));
        }
    }
}