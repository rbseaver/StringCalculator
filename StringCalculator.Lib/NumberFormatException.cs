using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace StringCalculator.Lib
{

    public class NumberFormatException : Exception
    {

        public NumberFormatException(string message) : base(message)
        {
        }

        public NumberFormatException() : base()
        {
        }

        public NumberFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NumberFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}