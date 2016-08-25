using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class MensajeSinEstadoDePersistenciaDefinido : IStatePersistencia
    {
        public ICollection<IRegistroMensaje> RegistroMensajes { get; }
        public void NuevoRegistro(IRegistroMensaje pNuevoRegistro)
        {
            if (!pNuevoRegistro.NoEsNulo())
                throw new RegistroNuloException("El nuevo registro no puede ser nulo");
            this.RegistroMensajes.Add(pNuevoRegistro);
        }
        public abstract EstadoPersistencia ObtenerEstadoPersistencia();
        public IRegistroMensaje ObtenerUltimoRegistroMensaje()
        {
            return this.RegistroMensajes.LastOrDefault();
        }

        public MensajeSinEstadoDePersistenciaDefinido()
        {
            this.RegistroMensajes = new List<IRegistroMensaje>();
        }
    }
}
