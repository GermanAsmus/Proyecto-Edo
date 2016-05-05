using System;
using System.Runtime.Serialization;

namespace Servicio.Excepciones
{
    [Serializable]
    internal class ProtocolException : ApplicationException
    {
        public ProtocolException(string message) : base(message) { }

        public ProtocolException(string message, Exception innerException) : base(message, innerException) { }
    }
}