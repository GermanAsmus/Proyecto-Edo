using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using ControlDependencia;

namespace Dominio
{
    public abstract class AgregarSimple<T> : ServicioAbstracto<T>, IAgregarSimple<T> where T : class
    {
        public AgregarSimple(IRepositorio<T> pRepositorio,IGestor pGestor) : base(pRepositorio,pGestor)
        {

        }
        public abstract void Agregar(T entidad);
    }
}
