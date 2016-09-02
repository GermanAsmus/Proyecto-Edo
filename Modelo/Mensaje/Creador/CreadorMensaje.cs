using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class CreadorMensaje : Creador<IMensajeDAO>
    {
        protected string iTipoEstructura;
        public CreadorMensaje(string pTipoEstructura)
        {
            this.iTipoEstructura = pTipoEstructura;
        }
    }
}