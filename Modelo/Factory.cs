using CapaInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Factory<T> : IFactory<T> where T : class
    {
        public abstract T AgregarEntidad();
    }
}
