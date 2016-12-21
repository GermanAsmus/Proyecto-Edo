﻿using System;
using System.Runtime.Serialization;

namespace Dominio.Excepciones
{
    public class PathInexistenteException : Exception
    {
        public PathInexistenteException()
        {
        }

        public PathInexistenteException(string message) : base(message)
        {
        }

        public PathInexistenteException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}