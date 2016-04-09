using System.Collections.Generic;

namespace Modelo
{
    public abstract class Mensaje
    {
        public string MensajeId { get; set; }
        public string Fecha { get; set; }

        public string Remitente { get; set; }
        public DireccionCorreo DireccionCorreo { get; set; }

        public string Asunto { get; set; }

        public string CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }

        public virtual ICollection<DireccionCorreo> Destinatario { get; set; }

        public Mensaje()
        {
            Destinatario = new List<DireccionCorreo>();
        }
    }
}
