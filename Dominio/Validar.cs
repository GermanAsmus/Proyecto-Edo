using ControlDependencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Validar<T> : IValidar where T : class
    {
        protected IServicio<T> Servicio { get; set; }
        public Validar(IServicio<T> pServicio)
        {
            Servicio = pServicio;
        }
        public abstract T Evaluar(T entidad);
    }
}
