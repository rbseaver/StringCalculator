namespace StringCalculator.Lib
{
    public interface IParserFactory
    {
        INumberParser Create(string input);
    }
}