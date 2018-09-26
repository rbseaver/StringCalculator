using System.Collections.Generic;

namespace StringCalculator.Lib
{
    public interface INumberParser
    {
        IEnumerable<int> Parse(string input);
    }
}