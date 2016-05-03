using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public abstract class Validar<T> : IValidar<T> where T : class
    {
        public abstract T Evaluar(T pEntidad, IRepositorio<T> pRepositorio);
    }
}
