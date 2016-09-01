using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorCuentaUsuario : CreadorCuenta
    {
        protected override ICuentaDTO CrearCuenta(string pDireccion)
        {
            ICuentaFactory factoryCuenta = new CuentaUsuarioFactory();
            return new CuentaUsuarioDAO(factoryCuenta, pDireccion).CuentaDTO;
        }
    }
}