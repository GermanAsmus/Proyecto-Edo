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
    public abstract class MensajeDAO : IEntidadDAO<IDireccionCorreoDTO>, IMensajeDAO
    {
        protected IEntidadDAO<IDireccionCorreoDTO> iServicioControlDirecciones;

        public abstract IMensajeDTO MensajeDTO { get; set; }
        protected IMensajeFactory iMensajeFactory;

        protected void RealizarMensaje()
        {
            this.MensajeDTO = this.iMensajeFactory.AgregarEstructura(typeof(MensajeCompletoDTO).Name);
        }
        /// <summary>
        /// Constructor de la clase.
        /// El estado de persistencia por defecto es "No_Guardado".
        /// </summary>
        public MensajeDAO(IMensajeFactory pMensajeFactory)
        {
            this.iServicioControlDirecciones = new EntidadDAO<IDireccionCorreoDTO>(new List<IDireccionCorreoDTO>());
            this.iMensajeFactory = pMensajeFactory;
            this.RealizarMensaje();
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

        public void Agregar(IDireccionCorreoDTO pEntidad)
        {
            iServicioControlDirecciones.Agregar(pEntidad);
        }

        public void Eliminar(IDireccionCorreoDTO pEntidad)
        {
            iServicioControlDirecciones.Eliminar(pEntidad);
        }

        public IEnumerable<IDireccionCorreoDTO> ObtenerSegun(Expression<Func<IDireccionCorreoDTO, bool>> pCriterio)
        {
            return iServicioControlDirecciones.ObtenerSegun(pCriterio);
        }

        public IDireccionCorreoDTO Obtener(Expression<Func<IDireccionCorreoDTO, bool>> pCriterio)
        {
            return iServicioControlDirecciones.Obtener(pCriterio);
        }
    }
}
