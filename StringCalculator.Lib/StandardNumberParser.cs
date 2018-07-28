using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{

    public class StandardNumberParser : INumberParser
    {
        public IEnumerable<int> Parse(string input, char[] possibleDelimiters)
        {
            return input.Split(possibleDelimiters)
                .Select(x => int.Parse(x));
        }
    }
}