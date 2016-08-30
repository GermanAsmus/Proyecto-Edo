using System;

namespace Modelo
{
    internal class RegistroNuloException : Exception
    {
        public RegistroNuloException()
        {
        }

        public RegistroNuloException(string message) : base(message)
        {
        }

        public RegistroNuloException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}