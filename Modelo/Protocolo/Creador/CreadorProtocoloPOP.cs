using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorProtocoloPOP : CreadorProtocolo
    {
        protected override IProtocoloDTO CrearProtocolo()
        {
            return new ProtocoloPOP();
        }
    }
}