using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdoUI.Entidades.Automapper_DTO
{
    public class InfoMensajeDTO
    {
        string Asunto { get; set; }
        string Fecha { get; set; }
        string Remitente { get; set; }
        IEnumerable<string> Destinatario { get; set; }
    }
}
