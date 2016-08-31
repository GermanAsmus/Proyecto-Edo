using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorProtocoloSMTP : CreadorProtocolo
    {
        protected override IProtocoloDTO CrearProtocolo()
        {
            return new ProtocoloSMTP();
        }
    }
}