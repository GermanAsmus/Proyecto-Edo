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
    public abstract class MensajeDAO : IMensajeDAO, IEstadoMensaje
    {
        protected IEntidadDAO<ICuentaDTO> iServicioControlDirecciones;

        public virtual IMensajeDTO MensajeDTO { get; set; }
        //protected MensajeFactory iMensajeFactory;

        /// <summary>
        /// Constructor de la clase.
        /// El estado de persistencia por defecto es "No_Guardado".
        /// </summary>
        public MensajeDAO(IMensajeDTO pMensajeDTO)
        {
            this.MensajeDTO = pMensajeDTO;

            this.iServicioControlDirecciones = new EntidadDAO<ICuentaDTO>(this.MensajeDTO.Destinatario);
        }
        /// <summary>
        /// Cambia el estado de persistencia del mensaje.
        /// (Guardado/No_Guardado).
        /// </summary>
        public void CambiarEstadoPersistencia()
        {
            if (this.ObtenerEstadoPersistencia() != EstadoPersistencia.Guardado.ToString())
                (this.MensajeDTO as MensajeDTO).EstadoPersistencia = EstadoPersistencia.Guardado;
            else
                (this.MensajeDTO as MensajeDTO).EstadoPersistencia = EstadoPersistencia.No_Guardado;

        }
        /// <summary>
        /// Obtiene el estado de persistencia del mensaje.
        /// (Guardado/No_Guardado).
        /// </summary>
        public string ObtenerEstadoPersistencia()
        {
            return (this.MensajeDTO as MensajeDTO).EstadoPersistencia.ToString();
        }

        public ICollection<ICuentaDTO> Agregar(ICuentaDTO pEntidad)
        {
            this.MensajeDTO.Destinatario = iServicioControlDirecciones.Agregar(pEntidad);
            return this.MensajeDTO.Destinatario;
        }

        public ICollection<ICuentaDTO> Eliminar(Expression<Func<ICuentaDTO, bool>> pCriterio)
        {
            this.MensajeDTO.Destinatario = iServicioControlDirecciones.Eliminar(pCriterio);
            return this.MensajeDTO.Destinatario;

        }

        public IEnumerable<ICuentaDTO> ObtenerSegun(Expression<Func<ICuentaDTO, bool>> pCriterio)
        {
            return iServicioControlDirecciones.ObtenerSegun(pCriterio);
        }

        public ICuentaDTO Obtener(Expression<Func<ICuentaDTO, bool>> pCriterio)
        {
            return iServicioControlDirecciones.Obtener(pCriterio);
        }

        public string ObtenerEstado()
        {
            return (this.MensajeDTO as MensajeDTO).Estado.ObtenerEstado();
        }

        public void CambiarEstado()
        {
            (this.MensajeDTO as MensajeDTO).Estado.CambiarEstado();
        }
    }
}
