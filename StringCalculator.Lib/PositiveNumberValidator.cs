using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Lib
{
    public class PositiveNumberValidator : INumberValidator
    {
        public void Validate(IEnumerable<int> numbers)
        {
            var hasNegatives = numbers.Any(x => x < 0);

            if (hasNegatives)
            {
                var negativeResults = string.Join(", ", numbers.Where(x => x < 0)
                    .Select(n => n.ToString())
                    .ToArray());

                throw new NumberFormatException($"Negatives not allowed: {negativeResults}");
            }
        }
    }
}