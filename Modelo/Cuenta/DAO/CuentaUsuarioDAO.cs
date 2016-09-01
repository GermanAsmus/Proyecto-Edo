using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Modelo
{
    public class CuentaUsuarioDAO : CuentaDAO
    {
        //Entidad de la direccion de correo a la que está relacionada la cuenta.
        public CuentaUsuarioDAO(ICuentaFactory pCuentaFactory, string pDireccion) : base(pCuentaFactory, pDireccion) { }

    }
}
