using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorMensajeNulo : CreadorMensaje
    {
        public CreadorMensajeNulo(string pTipoEstructura) : base(pTipoEstructura)
        {
        }

        protected override IMensajeDAO CrearEntidad()
        {
            return new MensajeNulo(null);
        }
    }
}