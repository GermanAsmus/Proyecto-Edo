using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeExternoCreador : CreadorMensaje
    {
        public MensajeExternoCreador(string pTipoEstructura) : base(pTipoEstructura)
        {
        }

        protected override IMensajeDAO CrearEntidad()
        {
            MensajeFactory factoryMensaje = new MensajeFactory(this.iTipoEstructura);
            return new MensajeExterno(factoryMensaje);
        }
    }
}