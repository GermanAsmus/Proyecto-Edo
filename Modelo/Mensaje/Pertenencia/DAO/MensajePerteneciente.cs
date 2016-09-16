using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class MensajePertenecienteDAO : IMensajeEstructurado, IEstado, IMensajeDAO
    {
        protected IMensajeEstructurado iMensajeEstructurado;

        public MensajePertenecienteDAO(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
           this.iMensajeEstructurado = 
        }

        public abstract EstrategiaPertenencia ObtenerPertenencia();

    }
}
