using System.Collections;
using System.Collections.Generic;

namespace Modelo
{
    public class DireccionCorreo
    {
        /// <summary>
        /// Direccion de Correo
        /// </summary>
        public string DireccionId { get; set; }

        public string CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }
    
        public virtual ICollection<Mensaje> MensajesDestinatario { get; set; }
        public virtual ICollection<Mensaje> MensajesRemitente { get; set; }

        public DireccionCorreo()
        {
            MensajesRemitente = new List<Mensaje>();
            MensajesDestinatario = new List<Mensaje>();
        }
    }
}
