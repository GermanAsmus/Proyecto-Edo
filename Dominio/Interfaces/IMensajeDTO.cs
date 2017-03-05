using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IMensajeDTO : IEntidadModelo
    {
        //Asunto del mensaje.
        string Asunto { get; set; }

        IDireccionCorreo Remitente { get; set; }
        byte RemitenteId { get; set; }

        ICollection<IDireccionCorreo> Destinatario { get; set; }

        string Contenido { get; set; }

    }
}
