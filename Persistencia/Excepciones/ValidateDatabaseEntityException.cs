using System;
using System.Runtime.Serialization;

namespace Persistencia.Excepciones
{
    [Serializable]
    internal class ValidateDatabaseEntityException : DatabaseException
    {
        public ValidateDatabaseEntityException(string message) : base(message) {  }

        public ValidateDatabaseEntityException(string message, Exception innerException) : base(message, innerException) { }
    }
}