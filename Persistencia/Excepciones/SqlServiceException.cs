using System;
using System.Runtime.Serialization;

namespace Persistencia.Excepciones
{
    [Serializable]
    internal class SqlServiceException : ServiceException
    {
        public SqlServiceException(string message) : base(message) {  }

        public SqlServiceException(string message, Exception innerException) : base(message, innerException) { }
    }
}