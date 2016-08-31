using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class CreadorProtocolo
    {
        protected abstract IProtocoloDTO CrearProtocolo();
        public IProtocoloDTO ObtenerProtocolo()
        {
            return this.CrearProtocolo();
        }
    }
}
