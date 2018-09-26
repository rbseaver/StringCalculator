using System.Collections.Generic;

namespace StringCalculator.Lib
{

    public class EmptyNumberParser : INumberParser
    {
        public IEnumerable<int> Parse(string input)
        {
            return new int[] { 0 };
        }
    }
}