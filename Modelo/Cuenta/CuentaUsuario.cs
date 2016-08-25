using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Modelo
{
    public class CuentaUsuario : Cuenta, ICuentaUsuario
    {
        //Nombre de la cuenta.
        public string Nombre { get; set; }
        //Contraseña de la cuenta
        public string Contraseña { get; set; }

        public IServidor Servidor { get; set; }
        //Entidad de la direccion de correo a la que está relacionada la cuenta.

        public CuentaUsuario() { }

        public string ReconocerServidor(IDireccionCorreo pDireccion)
        {
            return new MailAddress(pDireccion.DireccionDeCorreo).Host;
        }

    }
}
