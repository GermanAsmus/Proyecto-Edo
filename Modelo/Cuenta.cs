using CapaInterfaces;
using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;


namespace Modelo
{
    /// <summary>
    /// Entidad Cuenta, modela una cuenta de correo.
    /// </summary>
    public abstract class Cuenta : ICuenta
    {
        //Identificador único de la cuenta.
        public int Id { get; set; }
        
        //Identificador de la direccion de correo de la cuenta
        public int DireccionId { get; set; }
               
        public IDireccionCorreo DireccionCorreo { get; set; }
        
        //Constructor de la clase
        public Cuenta()
        {
        }

    }
}
