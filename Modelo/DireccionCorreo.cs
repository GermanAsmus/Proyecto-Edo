using System.Collections;
using System.Collections.Generic;

namespace Modelo
{
    public class DireccionCorreo : IEntidadModelo
    {
        public int Id { get; set; }

        public string DireccionDeCorreo { get; set; }

        public int CuentaId { get; set; }
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
