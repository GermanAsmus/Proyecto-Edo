using System;
using System.Runtime.Serialization;

namespace Servicio.Excepciones
{
    [Serializable]
    internal class Pop3Exception : ProtocolException
    {
        public Pop3Exception(string message) : base(message) { }

        public Pop3Exception(string message, Exception innerException) : base(message, innerException) { }
    }
}