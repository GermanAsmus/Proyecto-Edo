using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Modelo
{
    /// <summary>
    /// Modela un menaje (correo), como una entidad de base y no concluyente.
    /// Sus clases derivadas concretan el mensaje (agregando significado y siendo más responsables).
    /// </summary>
    public abstract class MensajeDAO : EntidadDAO<IDireccionCorreoDTO>, IMensajeDAO
    {

        public MensajeDTO MensajeDTO { get; set; }
        protected IMensajeFactory iMensajeFactory;
        /// <summary>
        /// Constructor de la clase.
        /// El estado de persistencia por defecto es "No_Guardado".
        /// </summary>
        public MensajeDAO(IMensajeFactory pMensajeFactory)
        {
            this.iMensajeFactory = pMensajeFactory;
            this.MensajeDTO = new MensajeDTO();
            this.MensajeDTO.EstadoPersistencia = EstadoPersistencia.No_Guardado;
        }
        /// <summary>
        /// Cambia el estado de persistencia del mensaje.
        /// (Guardado/No_Guardado).
        /// </summary>
        public void CambiarEstadoPersistencia()
        {
            if (this.MensajeDTO.EstadoPersistencia != EstadoPersistencia.Guardado)
                this.MensajeDTO.EstadoPersistencia = EstadoPersistencia.Guardado;
            else
                this.MensajeDTO.EstadoPersistencia = EstadoPersistencia.No_Guardado;

        }
        /// <summary>
        /// Obtiene el estado de persistencia del mensaje.
        /// (Guardado/No_Guardado).
        /// </summary>
        public string ObtenerEstadoPersistencia()
        {
            return this.MensajeDTO.EstadoPersistencia.ToString();
        }

        //IDEA: metodo estático que permita devolver todo el mensaje como un texto plano.

        ////Identificador de la dirección de correo asociada al mensaje, como dirección remitente.
        //public int DireccionId { get; set; }
        ////Entidad de la dirección de correo remitente.
        //public DireccionCorreo DireccionCorreo { get; set; }
    }
}
