using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class CreadorMensaje
    {
        protected abstract IMensajeDTO CrearMensaje();
        public IMensajeDTO ObtenerMensaje()
        {
            return this.CrearMensaje();
        }
    }
}