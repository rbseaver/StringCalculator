using System.Collections.Generic;

namespace StringCalculator.Lib
{
    public interface INumberValidator
    {
        void Validate(IEnumerable<int> numbers);
    }
}