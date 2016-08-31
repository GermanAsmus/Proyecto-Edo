using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeExternoFactory : IMensajeFactory
    {
        private IDictionary<string, IMensajeDTO> Estructuras;
        public MensajeExternoFactory()
        {
            this.Estructuras = new ControlEstructurasMensaje().ObtenerEstructuras();
        }
        public IMensajeDTO AgregarEstructura(string pTipoEstructura)
        {
            IMensajeDTO mensaje = null;
            try
            {
                mensaje = this.Estructuras[pTipoEstructura];
            }
            catch (KeyNotFoundException)
            {
                CreadorMensaje creador = new CreadorMensajeNulo();
                mensaje = creador.ObtenerMensaje();
            }

            return mensaje;
        }
    }
}