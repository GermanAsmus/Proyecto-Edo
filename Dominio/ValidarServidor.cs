using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ValidarServidor : Validar<Servidor>
    {
        public ValidarServidor(IServicio<Servidor> pServicio):base(pServicio)
        {

        }
        public override Servidor Evaluar(Servidor entidad)
        {
            var resultado = this.Servicio.Obtener(x => x.Nombre == entidad.Nombre);
            if (resultado != null)
                throw new ApplicationException("No existe el servidor");
            else
                return resultado;
        }
    }
}
