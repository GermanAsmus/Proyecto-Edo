using EdoUI.Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdoUI.Entidades.Automapper_DTO
{
    public class MensajeDTO
    {
        string Asunto { get; set; }
        string Remitente { get; set; }
        ICollection<string> Destinatario { get; set; }
        ICollection<IAdjunto> Adjuntos { get; set; }
        string Contenido { get; set; }
    }
}
