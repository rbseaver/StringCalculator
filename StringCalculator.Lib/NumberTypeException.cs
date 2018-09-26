using System;
using System.Runtime.Serialization;

namespace StringCalculator.Lib
{
    public class NumberTypeException : Exception
    {
        public NumberTypeException()
        {
        }

        public NumberTypeException(string message) : base(message)
        {
        }

        public NumberTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NumberTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}