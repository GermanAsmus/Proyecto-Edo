using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ProtocoloNulo : ProtocoloDTO
    {
        public ProtocoloNulo()
        {
            this.Host = string.Empty;
            this.Nombre = "Nulo";
            this.Puerto = -1;
            this.SSL = false;
        }
    }
}