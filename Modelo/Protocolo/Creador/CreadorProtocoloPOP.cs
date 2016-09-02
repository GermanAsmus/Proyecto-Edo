using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorProtocoloPOP : CreadorProtocolo
    {
        protected override IProtocoloDTO CrearEntidad()
        {
            return new ProtocoloPOP();
        }
    }
}