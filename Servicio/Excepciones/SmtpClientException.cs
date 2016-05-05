using System;
using System.Runtime.Serialization;

namespace Servicio.Excepciones
{
    [Serializable]
    internal class SmtpClientException : SmtpException
    {
        public SmtpClientException(string message) : base(message) { }

        public SmtpClientException(string message, Exception innerException) : base(message, innerException) { }
    }
}