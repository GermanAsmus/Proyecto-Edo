using CapaInterfaces;
using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Linq.Expressions;
using System.Linq;

namespace Modelo
{
    /// <summary>
    /// Entidad abstracta que modela una cuenta de correo.
    /// </summary>
    public class CuentaDAO : ICuentaDAO
    {
        #region Atributos
        protected IEntidadDAO<IMensajeDTO> iServicioControlMensajes { get; set; }

        /// <summary>
        /// Mantiene los atributos de la cuenta modelada.
        /// </summary>
        protected ICuentaDTO iCuentaDTO;

        ///// <summary>
        ///// Atributo responsable de realizar la cuenta cuando se instancie la clase.
        ///// </summary>
        //protected CuentaFactory iCuentaFactory;

        #endregion


        /// <summary>
        /// 
        /// Constructor de la clase.
        /// 
        /// La cuenta se realiza instanciado primeramente la clase DTO asociada 
        /// e insertando posteriormente la instancia del ServidorDAO correspondiente.
        /// </summary>
        /// <param name="pCuentaFactory">Clase responsable de definir el ServidorDAO correspondiente</param>
        public CuentaDAO(ICuentaDTO pCuentaDTO)
        {
            if (pCuentaDTO == null)
                throw new ArgumentNullException(nameof(pCuentaDTO));

            this.iCuentaDTO = pCuentaDTO;

            this.Configurar();
        }

        /// <summary>
        /// Al realizar la cuenta se instancia el servidor.
        /// El servidor se obtiene de la misma direccion de correo (ej: correo@gmail.com --> host = gmail)
        /// </summary>
        protected void Configurar()
        {
            string host = DireccionCorreoDTO.ObtenerHost(this.iCuentaDTO.DireccionCorreo);

            this.iServicioControlMensajes = new EntidadDAO<IMensajeDTO>(this.iCuentaDTO.Mensajes);

            this.iCuentaDTO.Servidor = new CreadorServidor().ObtenerServidor(host);
                
        }

        public virtual ICuentaDTO Cuenta
        {
            get
            {
                return this.iCuentaDTO;
            }
            set
            {
                this.iCuentaDTO = value;
            }
        }


        #region Control de los mensajes
        public ICollection<IMensajeDTO> Agregar(IMensajeDTO pEntidad)
        {
            this.iCuentaDTO.Mensajes = iServicioControlMensajes.Agregar(pEntidad);
            return this.iCuentaDTO.Mensajes;
        }

        public ICollection<IMensajeDTO> Eliminar(Expression<Func<IMensajeDTO, bool>> pCriterio)
        {
            this.iCuentaDTO.Mensajes = iServicioControlMensajes.Eliminar(pCriterio);
            return this.iCuentaDTO.Mensajes;

        }

        public IEnumerable<IMensajeDTO> ObtenerSegun(Expression<Func<IMensajeDTO, bool>> pCriterio)
        {
            return iServicioControlMensajes.ObtenerSegun(pCriterio);
        }

        public IMensajeDTO Obtener(Expression<Func<IMensajeDTO, bool>> pCriterio)
        {
            return iServicioControlMensajes.Obtener(pCriterio);
        }
        #endregion
    }
}
