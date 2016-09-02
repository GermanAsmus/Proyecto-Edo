using CapaInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Creador<T> : ICreador<T> where T: class
    {
        protected abstract T CrearEntidad();

        public T ObtenerEntidad()
        {
            return this.CrearEntidad();
        }

    }
}
