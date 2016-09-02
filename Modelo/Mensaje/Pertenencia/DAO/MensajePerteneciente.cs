using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class MensajePertenecienteDAO : MensajeDAO, IMensajePertenecienteDAO
    {
        public MensajePertenecienteDAO(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {

        }

        public abstract EstrategiaPertenencia ObtenerPertenencia();

    }
}
