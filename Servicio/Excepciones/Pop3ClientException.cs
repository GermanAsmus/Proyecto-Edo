using System;
using System.Runtime.Serialization;

namespace Servicio.Excepciones
{
    [Serializable]
    internal class Pop3ClientException : Pop3Exception
    {
        public Pop3ClientException(string message) : base(message) { }

        public Pop3ClientException(string message, Exception innerException) : base(message, innerException) { }
    }
}