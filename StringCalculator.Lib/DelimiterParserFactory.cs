namespace StringCalculator.Lib
{
    public static class DelimiterParserFactory
    {
        public static IDelimiterParser Create(bool customMarker)
        {
            switch (customMarker)
            {
                case true:
                    return new CustomDelimiterParser();
                default:
                    return new StandardDelimiterParser();
            }
        }
    }
}
