using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{

    public class NumberParser : INumberParser
    {
        public IEnumerable<int> Parse(string input, char[] possibleDelimiters)
        {
            if (input.StartsWith("//"))
            {
                input = input.Substring(4);
            }
            return input.Split(possibleDelimiters)
                .Select(x => int.Parse(x));
        }
    }
}