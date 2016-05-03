using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Cuenta : IEntidadModelo
    {
        public int Id { get; set; }
        //nombre de la cuenta
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public int ServidorId { get; set; }
        public Servidor Servidor { get; set; }

        //direccion de correo de la cuenta
        public int DireccionId { get; set; }
        public DireccionCorreo DireccionCorreo { get; set; }

        public virtual ICollection<Mensaje> Mensajes { get; set; }

        public Cuenta()
        {
            Mensajes = new List<Mensaje>();
        }
    }
}
