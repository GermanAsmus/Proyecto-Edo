using System;
using System.Runtime.Serialization;

namespace Persistencia.Excepciones
{
    [Serializable]
    internal class DatabaseException : ApplicationException
    {
        public DatabaseException(string message) : base(message) {  }

        public DatabaseException(string message, Exception innerException) : base(message, innerException) { }
    }
}