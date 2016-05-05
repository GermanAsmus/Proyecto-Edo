using System;
using System.Runtime.Serialization;

namespace Persistencia.Excepciones
{
    [Serializable]
    internal class ServiceException : ApplicationException
    {
        public ServiceException(string message) : base(message) {  }

        public ServiceException(string message, Exception innerException) : base(message, innerException) { }
    }
}