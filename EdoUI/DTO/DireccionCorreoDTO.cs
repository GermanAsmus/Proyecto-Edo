using System.Collections.Generic;

namespace EdoUI.DTO
{
    public class DireccionCorreoDTO
    {
        public string DireccionDeCorreo { get; set; }
        public virtual ICollection<MensajeDTO> MensajesDestinatario { get; set; }
        public virtual ICollection<MensajeDTO> MensajesRemitente { get; set; }
    }
}
