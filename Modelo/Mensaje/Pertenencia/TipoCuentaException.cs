using System;

namespace Modelo
{
    internal class TipoCuentaException : Exception
    {
        public TipoCuentaException()
        {
        }

        public TipoCuentaException(string message) : base(message)
        {
        }

        public TipoCuentaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}