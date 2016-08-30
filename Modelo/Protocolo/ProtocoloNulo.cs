using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    internal class ProtocoloNulo : IProtocolo
    {
        public string Host { get; set; }

        public string Nombre { get; }

        public int Puerto { get; set; }

        public bool SSL { get; set; }

        public ProtocoloNulo()
        {
            this.Host = string.Empty;
            this.Nombre = "Nulo";
            this.Puerto = -1;
            this.SSL = false;
        }
    }
}