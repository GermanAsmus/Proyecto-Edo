using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class MensajeDTO : IMensajeDTO
    {
        //Identificador único del mensaje
        public int Id { get; set; }
        //Asunto del mensaje.
        public string Asunto { get; set; }
        //Identificador de la cuenta asociada.
        public int CuentaId { get; set; }
        //Entidad de la cuenta asociada.
        public ICuentaDTO Cuenta { get; set; }
        // Colección de direcciones de correo como direcciones destinatarios.
        public virtual ICollection<ICuentaDTO> Destinatario { get; set; }

        /// <summary>
        /// Estado de persistencia del mensaje. (Guardado/No_Guardado).
        /// </summary>
        public EstadoPersistencia EstadoPersistencia { get; set; }

    }
}
