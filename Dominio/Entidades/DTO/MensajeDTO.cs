using EdoUI.DTO;
using System;
using System.Collections.Generic;
using Dominio.Entidades.DAO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class MensajeDTO : IMensajeCompletoDTO, IEstadoMensaje
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

        private EstadoPersistencia iEstadoPersistencia;
        public string EstadoDePersistencia
        {
            get { return this.iEstadoPersistencia.ToString(); }
            set
            {
                this.iEstadoPersistencia =
                    value == EstadoPersistencia.Guardado.ToString() ? 
                        EstadoPersistencia.Guardado : EstadoPersistencia.No_Guardado;
            }
        }

        private IEstadoMensaje iEstado;
        public string Estado
        {
            get { return this.iEstado.ObtenerEstado(); }
        }
        public void CambiarEstado()
        {
            this.iEstado.CambiarEstado();
        }

        public string Estructura
        {
            get
            {
                return (string.IsNullOrEmpty(Contenido) && Adjuntos == null) ? "incompleto" : "completo";
            }
        }

        public MensajeDTO()
        {
            this.Adjuntos = new List<IAdjuntoDTO>();
            this.Destinatario = new List<ICuentaDTO>();
        }
    }

    //El estado de persistencia de un mensaje completo puede variar en guardado o no guardado,
    //con persistencia se hace referencia a la capacidad de la entidad de permanecer en la base de datos.
    public enum EstadoPersistencia
    {
        Guardado,
        No_Guardado
    }
}
