using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Cuenta:IEntidad
    {
        //nombre de la cuenta
        public string CuentaId { get; set; }

        public string Contraseña { get; set; }

        public string ServidorId { get; set; }
        public Servidor Servidor { get; set; }

        //direccion de correo de la cuenta
        public string DireccionId { get; set; }
        public DireccionCorreo DireccionCorreo { get; set; }

        public virtual ICollection<Mensaje> Mensajes { get; set; }

        public Cuenta()
        {
            Mensajes = new List<Mensaje>();
        }
    }
}
