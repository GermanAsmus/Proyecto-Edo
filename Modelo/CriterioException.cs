using System;
using System.Runtime.Serialization;

namespace Modelo
{
    public class CriterioException : Exception
    {
        public CriterioException()
        {
        }

        public CriterioException(string message) : base(message)
        {
        }

        public CriterioException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}