using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeExternoCreador : CreadorMensaje
    {
        protected override IMensajeDTO CrearMensaje()
        {
            IMensajeFactory factoryMensaje = new MensajeExternoFactory();
            return new MensajeExterno(factoryMensaje).MensajeDTO;
        }
    }
}