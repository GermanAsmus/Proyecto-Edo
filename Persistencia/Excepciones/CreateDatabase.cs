using System;
using System.Runtime.Serialization;

namespace Persistencia.Excepciones
{
    [Serializable]
    internal class CreateDatabaseException : DatabaseException
    {
        public CreateDatabaseException(string message) : base(message) {  }

        public CreateDatabaseException(string message, Exception innerException) : base(message, innerException) { }
    }
}