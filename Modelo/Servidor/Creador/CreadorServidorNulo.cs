using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorServidorNulo : CreadorServidor
    {
        public override string ObtenerNombre()
        {
            return "nulo";
        }

        protected override IServidor CrearServidor()
        {
            return new ServidorNulo(null);
        }
    }
}
