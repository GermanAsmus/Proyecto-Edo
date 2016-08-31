using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Modelo
{
    public class CuentaUsuario : CuentaDAO
    {
        //Entidad de la direccion de correo a la que está relacionada la cuenta.
        public CuentaUsuario(ICuentaFactory pCuentaFactory, string pDireccion) : base(pCuentaFactory, pDireccion) { }

    }
}
