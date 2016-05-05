using System;
using System.Runtime.Serialization;

namespace Dominio.Excepciones
{
    [Serializable]
    internal class AddOperationException : InvalidRepositoryOperationException
    {
        public AddOperationException()
        {
        }

        public AddOperationException(string message) : base(message)
        {
        }
    }
}