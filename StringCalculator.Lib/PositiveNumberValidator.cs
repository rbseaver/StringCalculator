using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{
    public class PositiveNumberValidator : INumberValidator
    {
        public void Validate(IEnumerable<int> numbers)
        {
            if (numbers.Any(x => x < 0))
            {
                var negatives = numbers.Where(x => x < 0);
                throw new NumberTypeException("Negatives not allowed: " + string.Join(",", negatives.ToArray()));
            }
        }
    }
}