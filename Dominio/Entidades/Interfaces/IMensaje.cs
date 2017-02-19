using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Interfaces
{
    public interface IMensaje : IEntidadModelo, IEstadoMensaje
    {
        //Asunto del mensaje.
        string Asunto { get; set; }

        //Identificador de la cuenta asociada.
        int CuentaId { get; set; }

        //Entidad de la cuenta asociada.
        ICuenta Cuenta { get; set; }

        // Colección de direcciones de correo como direcciones destinatarios.
        ICollection<ICuenta> Destinatario { get; set; }

        //ICollection<IAdjunto> Adjuntos { get; set; }

        string Contenido { get; set; }

    }
}
