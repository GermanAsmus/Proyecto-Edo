using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class CreadorServidor
    {
        protected abstract IServidorDTO CrearServidor();

        public abstract string ObtenerNombre();

        public IServidorDTO ObtenerServidor()
        {
            return this.CrearServidor();
        }
    }
}