using System;
using System.Runtime.Serialization;

namespace Utilidades.Excepciones
{
    [Serializable]
    internal class CreateDirectoryException : ApplicationException
    {

        public CreateDirectoryException(string message) : base(message)
        {
        }

        public CreateDirectoryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}