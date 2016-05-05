using System;
using System.Runtime.Serialization;

namespace Persistencia.Excepciones
{
    [Serializable]
    internal class UpdateDatabaseException : DatabaseException
    {
        public UpdateDatabaseException(string message) : base(message) {  }

        public UpdateDatabaseException(string message, Exception innerException) : base(message, innerException) { }
    }
}