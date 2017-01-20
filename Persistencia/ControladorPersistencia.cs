using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dominio.Persistencia;
using Persistencia.Repositorios;
using Dominio.Entidades.Interfaces;

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

            this.iRepositorioCuenta = this.iUnitOfWork.ObtenerRepositorio<ICuenta>() as IRepositorioCuenta;
            this.iRepositorioMensaje = this.iUnitOfWork.ObtenerRepositorio<IMensaje>() as IRepositorioMensaje;
            this.iRepositorioAdjunto = this.iUnitOfWork.ObtenerRepositorio<IAdjunto>() as IRepositorioAdjunto;
            this.iRepositorioDireccionCorreo = this.iUnitOfWork.ObtenerRepositorio<IDireccionCorreo>() as IRepositorioDireccion;
        }

        public int Actualizar()
        {
            return this.iUnitOfWork.Commit();
        }

        #region manejo de cuenta
        public ICuenta ObtenerCuenta(int? pId)
        {
            return this.iRepositorioCuenta.Obtener(pId);
        }

        public ICuenta ObtenerCuenta(string pNombre = null)
        {
            return this.iRepositorioCuenta.Obtener(pNombre);
        }

        public IEnumerable<ICuenta> ObtenerCuentaSegun(int? pId)
        {
            return this.iRepositorioCuenta.ObtenerSegun(pId);
        }

        public IEnumerable<ICuenta> ObtenerCuentaSegun(string pNombre = null)
        {
            return this.iRepositorioCuenta.ObtenerSegun(pNombre);
        }

        public void Agregar(ICuenta pEntidad)
        {
            this.iRepositorioCuenta.Agregar(pEntidad);
        }

        public void Eliminar(ICuenta pEntidad)
        {
            this.iRepositorioCuenta.Eliminar(pEntidad);
        }

        #endregion

        #region manejo de direccion de correo
        public IDireccionCorreo ObtenerCuentaDireccionDeCorreo(int? pId)
        {
            return this.iRepositorioDireccionCorreo.Obtener(pId);
        }

        public IDireccionCorreo ObtenerCuentaDireccionDeCorreo(string pDireccion)
        {
            return this.iRepositorioDireccionCorreo.Obtener(pDireccion);
        }

        public IEnumerable<IDireccionCorreo> ObtenerCuentaDireccionDeCorreoSegun(int? pId)
        {
            return this.iRepositorioDireccionCorreo.ObtenerSegun(pId);
        }

        public IEnumerable<IDireccionCorreo> ObtenerCuentaDireccionDeCorreoSegun(string pDireccion)
        {
            return this.iRepositorioDireccionCorreo.ObtenerSegun(pDireccion);
        }

        public void Agregar(IDireccionCorreo pEntidad)
        {
            this.iRepositorioDireccionCorreo.Agregar(pEntidad);
        }

        public void Eliminar(IDireccionCorreo pEntidad)
        {
            this.iRepositorioDireccionCorreo.Eliminar(pEntidad);
        } 
        #endregion

        #region manejo de mensajes
        public IMensaje ObtenerMensaje(int? pId)
        {
            return this.iRepositorioMensaje.Obtener(pId);
        }

        public IMensaje ObtenerMensaje(string pAsunto = null)
        {
            return this.iRepositorioMensaje.Obtener(pAsunto);
        }

        public IEnumerable<IMensaje> ObtenerMensajeSegun(int? pId)
        {
            return this.iRepositorioMensaje.ObtenerSegun(pId);
        }

        public IEnumerable<IMensaje> ObtenerMensajeSegun(string Asunto = null)
        {
            return this.iRepositorioMensaje.ObtenerSegun(Asunto);
        }

        public void Agregar(IMensaje pEntidad)
        {
            this.iRepositorioMensaje.Agregar(pEntidad);
        }

        public void Eliminar(IMensaje pEntidad)
        {
            this.iRepositorioMensaje.Eliminar(pEntidad);
        }

        #endregion

        #region manejo de adjuntos
        public IAdjunto ObtenerAdjunto(int pId)
        {
            return this.iRepositorioAdjunto.Obtener(pId);
        }

        public IAdjunto ObtenerAdjunto(string pCodigo)
        {
            return this.iRepositorioAdjunto.Obtener(pCodigo);
        }

        public IEnumerable<IAdjunto> ObtenerAdjuntoSegun(int? pId)
        {
            return this.iRepositorioAdjunto.ObtenerSegun(pId);
        }

        public IEnumerable<IAdjunto> ObtenerAdjuntoSegun(string pCodigo = null)
        {
            return this.iRepositorioAdjunto.ObtenerSegun(pCodigo);
        }

        public void Agregar(IAdjunto pEntidad)
        {
            this.iRepositorioAdjunto.Agregar(pEntidad);
        }

        public void Eliminar(IAdjunto pEntidad)
        {
            this.iRepositorioAdjunto.Eliminar(pEntidad);
        } 
        #endregion
    }
}
