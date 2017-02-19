using System;
using System.Runtime.Serialization;

namespace Servicio.Excepciones
{
    [Serializable]
    public class SmtpException : ProtocolException
    {
        public SmtpException(string message) : base(message) { }

        public SmtpException(string message, Exception innerException) : base(message, innerException) { }
    }
}