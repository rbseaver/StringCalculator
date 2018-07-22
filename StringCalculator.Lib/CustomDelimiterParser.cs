namespace StringCalculator.Lib
{
    public class CustomDelimiterParser : IDelimiterParser
    {
        public char[] Parse(string input)
        {
            return new[] { input[2] };
        }
    }
}
