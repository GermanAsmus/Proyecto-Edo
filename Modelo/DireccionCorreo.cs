using System.Collections;
using System.Collections.Generic;

namespace Modelo
{
    /// <summary>
    /// Entidad DireccionCorreo, modela una dirección de correo. Ej: miCorreo@correo.com
    /// </summary>
    public class DireccionCorreo : IEntidadModelo
    {
        //Identificador único de la direccion de correo.
        public int Id { get; set; }
        //Direccion de correo real de la entidad. Ej: miCorreo@correo.com
        public string DireccionDeCorreo { get; set; }
        //Identificador de la cuenta a la que está asociada la dirección de correo.
        public int CuentaId { get; set; }
        //Entidad Cuenta a la que está asociada la dirección de correo.
        public Cuenta Cuenta { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo destinatario.
        public virtual ICollection<Mensaje> MensajesDestinatario { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo remitente.
        public virtual ICollection<Mensaje> MensajesRemitente { get; set; }

        public DireccionCorreo()
        {
            MensajesRemitente = new List<Mensaje>();
            MensajesDestinatario = new List<Mensaje>();
        }
    }
}
