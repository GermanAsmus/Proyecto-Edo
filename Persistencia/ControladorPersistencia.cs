using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dominio.Persistencia;
using EdoUI.Entidades.DTO;
using Persistencia.Repositorios;

namespace Persistencia
{
    public class ControladorPersistencia : IControladorPersistencia

    {
        private IUnitOfWork iUnitOfWork;

        private IRepositorioCuenta iRepositorioCuenta;
        private IRepositorioMensaje iRepositorioMensaje;
        private IRepositorioAdjunto iRepositorioAdjunto;
        private IRepositorioDireccion iRepositorioDireccionCorreo;


        public ControladorPersistencia(IUnitOfWork pUnitOfWork)
        {
            this.iUnitOfWork = pUnitOfWork;

            this.iRepositorioCuenta = this.iUnitOfWork.ObtenerRepositorio<ICuentaDTO>() as IRepositorioCuenta;
            this.iRepositorioMensaje = this.iUnitOfWork.ObtenerRepositorio<IMensajeDTO>() as IRepositorioMensaje;
            this.iRepositorioAdjunto = this.iUnitOfWork.ObtenerRepositorio<IAdjuntoDTO>() as IRepositorioAdjunto;
            this.iRepositorioDireccionCorreo = this.iUnitOfWork.ObtenerRepositorio<IDireccionCorreoDTO>() as IRepositorioDireccion;
        }

        public int Actualizar()
        {
            return this.iUnitOfWork.Commit();
        }

        #region manejo de cuenta
        public ICuentaDTO ObtenerCuenta(int? pId)
        {
            return this.iRepositorioCuenta.Obtener(pId);
        }

        public ICuentaDTO ObtenerCuenta(string pNombre = null)
        {
            return this.iRepositorioCuenta.Obtener(pNombre);
        }

        public IEnumerable<ICuentaDTO> ObtenerCuentaSegun(int? pId)
        {
            return this.iRepositorioCuenta.ObtenerSegun(pId);
        }

        public IEnumerable<ICuentaDTO> ObtenerCuentaSegun(string pNombre = null)
        {
            return this.iRepositorioCuenta.ObtenerSegun(pNombre);
        }

        public void Agregar(ICuentaDTO pEntidad)
        {
            this.iRepositorioCuenta.Agregar(pEntidad);
        }

        public void Eliminar(ICuentaDTO pEntidad)
        {
            this.iRepositorioCuenta.Eliminar(pEntidad);
        }

        #endregion

        #region manejo de direccion de correo
        public IDireccionCorreoDTO ObtenerCuentaDireccionDeCorreo(int? pId)
        {
            return this.iRepositorioDireccionCorreo.Obtener(pId);
        }

        public IDireccionCorreoDTO ObtenerCuentaDireccionDeCorreo(string pDireccion)
        {
            return this.iRepositorioDireccionCorreo.Obtener(pDireccion);
        }

        public IEnumerable<IDireccionCorreoDTO> ObtenerCuentaDireccionDeCorreoSegun(int? pId)
        {
            return this.iRepositorioDireccionCorreo.ObtenerSegun(pId);
        }

        public IEnumerable<IDireccionCorreoDTO> ObtenerCuentaDireccionDeCorreoSegun(string pDireccion)
        {
            return this.iRepositorioDireccionCorreo.ObtenerSegun(pDireccion);
        }

        public void Agregar(IDireccionCorreoDTO pEntidad)
        {
            this.iRepositorioDireccionCorreo.Agregar(pEntidad);
        }

        public void Eliminar(IDireccionCorreoDTO pEntidad)
        {
            this.iRepositorioDireccionCorreo.Eliminar(pEntidad);
        } 
        #endregion

        #region manejo de mensajes
        public IMensajeDTO ObtenerMensaje(int? pId)
        {
            return this.iRepositorioMensaje.Obtener(pId);
        }

        public IMensajeDTO ObtenerMensaje(string pAsunto = null)
        {
            return this.iRepositorioMensaje.Obtener(pAsunto);
        }

        public IEnumerable<IMensajeDTO> ObtenerMensajeSegun(int? pId)
        {
            return this.iRepositorioMensaje.ObtenerSegun(pId);
        }

        public IEnumerable<IMensajeDTO> ObtenerMensajeSegun(string Asunto = null)
        {
            return this.iRepositorioMensaje.ObtenerSegun(Asunto);
        }

        public void Agregar(IMensajeDTO pEntidad)
        {
            this.iRepositorioMensaje.Agregar(pEntidad);
        }

        public void Eliminar(IMensajeDTO pEntidad)
        {
            this.iRepositorioMensaje.Eliminar(pEntidad);
        }

        #endregion

        #region manejo de adjuntos
        public IAdjuntoDTO ObtenerAdjunto(int pId)
        {
            return this.iRepositorioAdjunto.Obtener(pId);
        }

        public IAdjuntoDTO ObtenerAdjunto(string pCodigo)
        {
            return this.iRepositorioAdjunto.Obtener(pCodigo);
        }

        public IEnumerable<IAdjuntoDTO> ObtenerAdjuntoSegun(int? pId)
        {
            return this.iRepositorioAdjunto.ObtenerSegun(pId);
        }

        public IEnumerable<IAdjuntoDTO> ObtenerAdjuntoSegun(string pCodigo = null)
        {
            return this.iRepositorioAdjunto.ObtenerSegun(pCodigo);
        }

        public void Agregar(IAdjuntoDTO pEntidad)
        {
            this.iRepositorioAdjunto.Agregar(pEntidad);
        }

        public void Eliminar(IAdjuntoDTO pEntidad)
        {
            this.iRepositorioAdjunto.Eliminar(pEntidad);
        } 
        #endregion
    }
}
