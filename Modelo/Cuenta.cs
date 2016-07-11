using System;
using System.Collections.Generic;


namespace Modelo
{
    /// <summary>
    /// Entidad Cuenta, modela una cuenta de correo.
    /// </summary>
    public class Cuenta : IEntidadModelo
    {
        //Identificador único de la cuenta.
        public int Id { get; set; }
        //Nombre de la cuenta.
        public string Nombre { get; set; }

        public string Contraseña { get; set; }

        //Identificador de la direccion de correo de la cuenta
        public int DireccionId { get; set; }
        //Entidad de la direccion de correo a la que está relacionada la cuenta.
        public DireccionCorreo DireccionCorreo { get; set; }
        //Colección de mensjes que mantiene la cuenta.
        public virtual ICollection<Mensaje> Mensajes { get; set; }

        public Cuenta()
        {
            Mensajes = new List<Mensaje>();
        }

        //encriptar contrasña


    }
}
