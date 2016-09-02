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
    public abstract class CuentaDAO : IEntidadDAO<IMensajeDTO>, ICuentaDAO
    {

        protected IEntidadDAO<IMensajeDTO> iServicioControlMensajes;

        /// <summary>
        /// Mantiene los atributos de la cuenta modelada.
        /// </summary>
        public virtual ICuentaDTO CuentaDTO { get; set; }
        /// <summary>
        /// Atributo responsable de realizar la cuenta cuando se instancie la clase.
        /// </summary>
        protected CuentaFactory iCuentaFactory;

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
            if (pCuentaDTO==null)
                throw new ArgumentNullException(nameof(pCuentaDTO));
        }

        /// <summary>
        /// Al realizar la cuenta se instancia el servidor.
        /// El servidor se obtiene de la misma direccion de correo (ej: correo@gmail.com --> host = gmail)
        /// </summary>
        protected void RealizarCuenta()
        {
            this.CuentaDTO.Servidor = this.iCuentaFactory.AgregarEntidad();
        }

        public void Agregar(IMensajeDTO pEntidad)
        {
            iServicioControlMensajes.Agregar(pEntidad);
        }

        public void Eliminar(IMensajeDTO pEntidad)
        {
            iServicioControlMensajes.Eliminar(pEntidad);
        }

        public IEnumerable<IMensajeDTO> ObtenerSegun(Expression<Func<IMensajeDTO, bool>> pCriterio)
        {
            return iServicioControlMensajes.ObtenerSegun(pCriterio);
        }

        public IMensajeDTO Obtener(Expression<Func<IMensajeDTO, bool>> pCriterio)
        {
            return iServicioControlMensajes.Obtener(pCriterio);
        }
    }
}
