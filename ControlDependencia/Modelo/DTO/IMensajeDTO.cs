using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces.Modelo
{
    public interface IMensajeDTO : IEntidadModelo
    {
        //Asunto del mensaje.
        string Asunto { get; set; }

        //Identificador de la cuenta asociada.
        int CuentaId { get; set; }

        //Entidad de la cuenta asociada.
        ICuentaDTO Cuenta { get; set; }

        // Colección de direcciones de correo como direcciones destinatarios.
        ICollection<ICuentaDTO> Destinatario { get; set; }

    }
}
