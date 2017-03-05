using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface ICuentaDeUsuarioDTO : IEntidadModelo
    {
        /// <summary>
        /// Refiere a la dirección de correo de la cuenta del usuario.
        /// </summary>
        IDireccionCorreo DireccionDeCorreo { get; set; }

        /// <summary>
        /// Identificador de la dirección de correo de la cuenta del usuario.
        /// </summary>
        byte DireccionId { get; set; }

        /// <summary>
        /// Contraseña de la cuenta del usuario
        /// </summary>
        string Contraseña { get; set; }

        /// <summary>
        /// Nombre que identifica a la cuenta
        /// </summary>
        string Nombre { get; set; }

        /// <summary>
        /// Servidor asociado a la cuenta. Mantiene los datos del servicio de mensajería remota.
        /// </summary>
        IServidor Servidor { get; set; }
    }
}
