using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorCuentaExterna : CreadorCuenta
    {
        protected override ICuenta CrearCuenta(string pDireccion)
        {
            ICuentaFactory factoryCuenta = new CuentaExternaFactory();
            return new CuentaExterna(factoryCuenta, pDireccion); //Cuando se instancia la cuenta, se realiza así misma.
        }
    }
}