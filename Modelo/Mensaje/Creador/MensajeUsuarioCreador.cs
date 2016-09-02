using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeUsuarioCreador : CreadorMensaje
    {
        public MensajeUsuarioCreador(string pTipoEstructura) : base(pTipoEstructura)
        {
        }

        protected override IMensajeDAO CrearEntidad()
        {
            MensajeFactory factoryMensaje = new MensajeFactory(this.iTipoEstructura);
            return new MensajeUsuario(factoryMensaje);
        }
    }
}