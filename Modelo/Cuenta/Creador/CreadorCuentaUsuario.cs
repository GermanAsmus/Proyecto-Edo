using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorCuentaUsuario : CreadorCuenta
    {
        protected override ICuenta CrearCuenta(string pDireccion)
        {
            ICuentaFactory factoryCuenta = new CuentaUsuarioFactory();
            return new CuentaUsuario(factoryCuenta, pDireccion);//Cuando se instancia la cuenta, se realiza así misma.
        }
    }
}