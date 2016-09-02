using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeFactory : Factory<IMensajeDTO>
    {
        protected IDictionary<string, IMensajeDTO> Estructuras;
        private string iTipoEstructura;
        public MensajeFactory(string pTipoEstructura)
        {
            this.Estructuras = new ControlEstructurasMensaje().ObtenerEstructuras();
            this.iTipoEstructura = pTipoEstructura;
        }
        public override IMensajeDTO AgregarEntidad()
        {
            IMensajeDTO mensaje = null;
            try
            {
                mensaje = this.Estructuras[iTipoEstructura];
            }
            catch (KeyNotFoundException)
            {
                mensaje = new MensajeNuloDTO();
            }

            return mensaje;
        }
    }
}