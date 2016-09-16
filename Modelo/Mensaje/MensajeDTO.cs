using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MensajeDTO : IMensajeCompletoDTO
    {

        #region Atributos Mensaje Estandar
        
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

        #endregion

        #region Atributos Mensaje Completo

        // Contenido en Texto Plano
        public string Contenido { get; set; }

        // Coleccion de adjuntos del mensaje.
        public virtual ICollection<IAdjuntoDTO> Adjuntos { get; set; }

        #endregion

        /// <summary>
        /// Estado de persistencia del mensaje. (Guardado/No_Guardado).
        /// </summary>
        public EstadoPersistencia EstadoPersistencia { get; set; }
               
        public string Estructura
        {
            get
            {
                if (string.IsNullOrEmpty(Contenido) && Adjuntos == null)
                    return "incompleto";

                return "completo";
            }
        }

        public IEstadoMensaje Estado { get; set; }


        public MensajeDTO()
        {
            this.Adjuntos = new List<IAdjuntoDTO>();
            this.Destinatario = new List<ICuentaDTO>();

        }
    }
}
