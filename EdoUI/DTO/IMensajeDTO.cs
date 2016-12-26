using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdoUI.DTO
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

        //Estado de persistencia del mensaje. (Guardado/No_Guardado).
        string EstadoDePersistencia { get; set; }

        string Estado { get; }
        void CambiarEstado();
        string Estructura { get; }
    }
}
