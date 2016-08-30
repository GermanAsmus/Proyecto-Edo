using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class CreadorServidor
    {
        protected abstract IServidor CrearServidor();

        public abstract string ObtenerNombre();

        public IServidor ObtenerServidor()
        {
            return this.CrearServidor();
        }
    }
}