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
        public ValidarServidor(IServicio<Servidor> pServicio) : base(pServicio)
        {

        }
        public override Task<Servidor> Evaluar(Servidor entidad)
        {
            //var resultado = 
            return this.Servicio.Obtener(x => x.Nombre == entidad.Nombre).ContinueWith((servidor) =>
            {
                if (servidor.Result != null)
                    throw new ApplicationException("No existe el servidor");
                else
                    return servidor.Result;
            });
            //if (resultado != null)
            //    throw new ApplicationException("No existe el servidor");
            //else
            //    return resultado;
        }
    }
}
