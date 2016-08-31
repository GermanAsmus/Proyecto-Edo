using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class CreadorCuenta
    {

        protected abstract ICuentaDTO CrearCuenta(string pDireccion);

        public ICuentaDTO ObtenerCuenta(string pDireccion)
        {
            return this.CrearCuenta(pDireccion);
        }

    }
}