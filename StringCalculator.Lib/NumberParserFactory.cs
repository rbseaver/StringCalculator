using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Lib
{
    public static class NumberParserFactory
    {
        public static INumberParser Create(bool customMarker)
        {
            switch (customMarker)
            {
                case true:
                    return new CustomerDelimiterNumberParser();
                default:
                    return new StandardNumberParser();
            }
        }
    }
}
