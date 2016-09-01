using System;
using System.Runtime.Serialization;

namespace Modelo
{
    public class MensajeSetException : Exception
    {
        public MensajeSetException()
        {
        }

        public MensajeSetException(string message) : base(message)
        {
        }

        public MensajeSetException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}