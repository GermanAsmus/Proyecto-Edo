using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorProtocoloSMTP : CreadorProtocolo
    {
        protected override IProtocoloDTO CrearEntidad()
        {
            return new ProtocoloSMTP();
        }
    }
}