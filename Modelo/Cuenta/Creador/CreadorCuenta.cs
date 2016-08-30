using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class CreadorCuenta
    {
        protected abstract ICuenta CrearCuenta(string pDireccion);

        public ICuenta ObtenerCuenta(string pDireccion)
        {
            return this.CrearCuenta(pDireccion);
        }

    }
}