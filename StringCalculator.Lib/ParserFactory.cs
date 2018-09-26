namespace StringCalculator.Lib
{
    public class ParserFactory : IParserFactory
    {
        public INumberParser Create(string input)
        {
            if (input.StartsWith("//"))
            {
                return new ExplicitDelimiterParser();
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