namespace StringCalculator.Lib
{
    public class ParserFactory : IParserFactory
    {
        public INumberParser Create(string input)
        {
            if (input.IndexOf("][") > 0)
            {
                return new MultipleDelimiterParser();
            }
            else if (input.StartsWith("//["))
            {
                return new VariableLengthDelimiterNumberParser();
            }
            else if (input.StartsWith("//"))
            {
                return new ExplicitDelimiterNumberParser();
            }
            else if (input.Length == 0)
            {
                return new EmptyNumberParser();
            }
            else
            {
                return new StandardNumberParser();
            }
        }
    }
}