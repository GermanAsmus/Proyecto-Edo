using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CapaInterfaces;
using CapaInterfaces.Modelo;
using CapaInterfaces.Persistencia;

namespace Persistencia
{
    public class Controlador : IControlador

    {
        internal IUnitOfWork iUnitOfWork;

        internal IRepositorioCompleto<ICuentaDTO> iRepositorioCuenta;
        internal IRepositorioCompleto<IMensajeDTO> iRepositorioMensaje;
        internal IRepositorioCompleto<IAdjuntoDTO> iRepositorioAdjunto;
        internal IRepositorioCompleto<IDireccionCorreoDTO> iRepositorioDireccionCorreo;


        public Controlador(IUnitOfWork pUnitOfWork)
        {
            this.iUnitOfWork = pUnitOfWork;

            this.iRepositorioCuenta = this.iUnitOfWork.ObtenerRepositorio<ICuentaDTO>();
            this.iRepositorioMensaje = this.iUnitOfWork.ObtenerRepositorio<IMensajeDTO>();
            this.iRepositorioAdjunto = this.iUnitOfWork.ObtenerRepositorio<IAdjuntoDTO>();
            this.iRepositorioDireccionCorreo = this.iUnitOfWork.ObtenerRepositorio<IDireccionCorreoDTO>();
        }

        public int Actualizar()
        {
            return this.iUnitOfWork.Commit();
        }

        #region Control de cuentas

        public void Agregar(ICuentaDTO pEntidad)
        {
            iRepositorioCuenta.Agregar(pEntidad);
        }

        public void Eliminar(ICuentaDTO pEntidad)
        {
            iRepositorioCuenta.Eliminar(pEntidad);
        }

        public IEnumerable<ICuentaDTO> Todos()
        {
            return iRepositorioCuenta.Todos();
        }

        public IEnumerable<ICuentaDTO> ObtenerSegun(Expression<Func<ICuentaDTO, bool>> pCriterio)
        {
            return iRepositorioCuenta.ObtenerSegun(pCriterio);
        }

        public ICuentaDTO Obtener(Expression<Func<ICuentaDTO, bool>> pCriterio)
        {
            return iRepositorioCuenta.Obtener(pCriterio);
        }

        #endregion

        #region Control de mensajes

        public void Agregar(IMensajeDTO pEntidad)
        {
            iRepositorioMensaje.Agregar(pEntidad);
        }

        public void Eliminar(IMensajeDTO pEntidad)
        {
            iRepositorioMensaje.Eliminar(pEntidad);
        }

        IEnumerable<IMensajeDTO> IRepositorioEstandar<IMensajeDTO>.Todos()
        {
            return iRepositorioMensaje.Todos();
        }

        public IEnumerable<IMensajeDTO> ObtenerSegun(Expression<Func<IMensajeDTO, bool>> pCriterio)
        {
            return iRepositorioMensaje.ObtenerSegun(pCriterio);
        }

        public IMensajeDTO Obtener(Expression<Func<IMensajeDTO, bool>> pCriterio)
        {
            return iRepositorioMensaje.Obtener(pCriterio);
        }


        #endregion

        #region Control de adjuntos

        public void Agregar(IAdjuntoDTO pEntidad)
        {
            iRepositorioAdjunto.Agregar(pEntidad);
        }

        public void Eliminar(IAdjuntoDTO pEntidad)
        {
            iRepositorioAdjunto.Eliminar(pEntidad);
        }

        IEnumerable<IAdjuntoDTO> IRepositorioEstandar<IAdjuntoDTO>.Todos()
        {
            return iRepositorioAdjunto.Todos();
        }

        public IEnumerable<IAdjuntoDTO> ObtenerSegun(Expression<Func<IAdjuntoDTO, bool>> pCriterio)
        {
            return iRepositorioAdjunto.ObtenerSegun(pCriterio);
        }

        public IAdjuntoDTO Obtener(Expression<Func<IAdjuntoDTO, bool>> pCriterio)
        {
            return iRepositorioAdjunto.Obtener(pCriterio);
        }

        #endregion

        #region Control de direcciones de correo

        public void Agregar(IDireccionCorreoDTO pEntidad)
        {
            iRepositorioDireccionCorreo.Agregar(pEntidad);
        }

        public void Eliminar(IDireccionCorreoDTO pEntidad)
        {
            iRepositorioDireccionCorreo.Eliminar(pEntidad);
        }

        IEnumerable<IDireccionCorreoDTO> IRepositorioEstandar<IDireccionCorreoDTO>.Todos()
        {
            return iRepositorioDireccionCorreo.Todos();
        }

        public IEnumerable<IDireccionCorreoDTO> ObtenerSegun(Expression<Func<IDireccionCorreoDTO, bool>> pCriterio)
        {
            return iRepositorioDireccionCorreo.ObtenerSegun(pCriterio);
        }

        public IDireccionCorreoDTO Obtener(Expression<Func<IDireccionCorreoDTO, bool>> pCriterio)
        {
            return iRepositorioDireccionCorreo.Obtener(pCriterio);
        }


        #endregion

    }
}
