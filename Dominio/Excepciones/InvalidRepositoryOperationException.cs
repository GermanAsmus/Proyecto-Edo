using System;
using System.Runtime.Serialization;

namespace Dominio.Excepciones
{
    [Serializable]
    internal class InvalidRepositoryOperationException : ApplicationException
    {
        public InvalidRepositoryOperationException()
        {
        }

        public InvalidRepositoryOperationException(string message) : base(message)
        {
        }
    }
}