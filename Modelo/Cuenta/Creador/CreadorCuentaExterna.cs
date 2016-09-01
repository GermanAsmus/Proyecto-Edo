using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorCuentaExterna : CreadorCuenta
    {
        protected override ICuentaDTO CrearCuenta(string pDireccion)
        {
            ICuentaFactory factoryCuenta = new CuentaExternaFactory();
            return new CuentaExternaDAO(factoryCuenta, pDireccion).CuentaDTO;
        }
    }
}