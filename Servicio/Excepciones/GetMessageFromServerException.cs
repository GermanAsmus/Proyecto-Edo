using System;
using System.Runtime.Serialization;

namespace Servicio.Excepciones
{
    [Serializable]
    internal class GetMessageFromServerException : Pop3Exception
    {
        public GetMessageFromServerException(string message) : base(message) { }

        public GetMessageFromServerException(string message, Exception innerException) : base(message, innerException) { }
    }
}