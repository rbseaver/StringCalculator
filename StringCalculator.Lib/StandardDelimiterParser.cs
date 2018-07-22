using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{

    public class StandardDelimiterParser : IDelimiterParser
    {
        private readonly List<char> delimiters = new List<char>
        {
            ',','\n'
        };

        public char[] Parse(string input)
        {
            return delimiters.ToArray();
        }
    }
}