using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using ControlDependencia;

namespace Dominio
{
    public abstract class AgregarCompuesto<T1, T2> : ServicioAbstracto<T1>, IAgregarCompuesto<T1, T2> where T1 : class where T2 : class
    {
        public AgregarCompuesto(IRepositorio<T1> pRepositorio,IGestor pGestor) : base(pRepositorio,pGestor)
        {

        }
        public abstract Task Agregar(T1 hijo, T2 padre);
    }
}
