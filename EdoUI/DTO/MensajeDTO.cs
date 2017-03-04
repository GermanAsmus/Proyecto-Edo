using System.Collections.Generic;

namespace EdoUI.DTO
{
    public class MensajeDTO
    {
        public string Asunto { get; set; }

        public DireccionCorreoDTO Remitente { get; set; }

        public ICollection<DireccionCorreoDTO> Destinatario { get; set; }

        public string Contenido { get; set; }
    }
}
