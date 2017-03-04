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
        //private IRepositorioAdjunto iRepositorioAdjunto;
        private IRepositorioDireccion iRepositorioDireccionCorreo;


        public ControladorPersistencia(IUnitOfWork pUnitOfWork)
        {
            this.iUnitOfWork = pUnitOfWork;

            this.iRepositorioCuenta = this.iUnitOfWork.ObtenerRepositorio<ICuenta>() as IRepositorioCuenta;
            this.iRepositorioMensaje = this.iUnitOfWork.ObtenerRepositorio<IMensaje>() as IRepositorioMensaje;
            //this.iRepositorioAdjunto = this.iUnitOfWork.ObtenerRepositorio<IAdjunto>() as IRepositorioAdjunto;
            this.iRepositorioDireccionCorreo = this.iUnitOfWork.ObtenerRepositorio<IDireccionCorreo>() as IRepositorioDireccion;
        }

        public int Actualizar()
        {
            return this.iUnitOfWork.Commit();
        }

        #region manejo de cuenta
        public ICuenta ObtenerCuenta(int? pId)
        {
            return this.iRepositorioCuenta.ObtenerUno(pId);
        }

        public ICuenta ObtenerCuenta(string pNombre = null)
        {
            return this.iRepositorioCuenta.ObtenerUno(pNombre);
        }

        public IEnumerable<ICuenta> ObtenerCuentaTodos(int? pId)
        {
            return this.iRepositorioCuenta.ObtenerTodos(pId);
        }

        public IEnumerable<ICuenta> ObtenerCuentaTodos(string pNombre = null)
        {
            return this.iRepositorioCuenta.ObtenerTodos(pNombre);
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
            return this.iRepositorioDireccionCorreo.ObtenerUno(pId);
        }

        public IDireccionCorreo ObtenerCuentaDireccionDeCorreo(string pDireccion)
        {
            return this.iRepositorioDireccionCorreo.ObtenerUno(pDireccion);
        }

        public IEnumerable<IDireccionCorreo> ObtenerCuentaDireccionDeCorreoTodos(int? pId)
        {
            return this.iRepositorioDireccionCorreo.ObtenerTodos(pId);
        }

        public IEnumerable<IDireccionCorreo> ObtenerCuentaDireccionDeCorreoTodos(string pDireccion)
        {
            return this.iRepositorioDireccionCorreo.ObtenerTodos(pDireccion);
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
            return this.iRepositorioMensaje.ObtenerUno(pId);
        }

        public IMensaje ObtenerMensaje(string pAsunto = null)
        {
            return this.iRepositorioMensaje.ObtenerUno(pAsunto);
        }

        public IEnumerable<IMensaje> ObtenerMensajeTodos(int? pId)
        {
            return this.iRepositorioMensaje.ObtenerTodos(pId);
        }

        public IEnumerable<IMensaje> ObtenerMensajeTodos(string Asunto = null)
        {
            return this.iRepositorioMensaje.ObtenerTodos(Asunto);
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

        //#region manejo de adjuntos
        //public IAdjunto ObtenerAdjunto(int pId)
        //{
        //    return this.iRepositorioAdjunto.Obtener(pId);
        //}

        //public IAdjunto ObtenerAdjunto(string pCodigo)
        //{
        //    return this.iRepositorioAdjunto.Obtener(pCodigo);
        //}

        //public IEnumerable<IAdjunto> ObtenerAdjuntoTodos(int? pId)
        //{
        //    return this.iRepositorioAdjunto.ObtenerTodos(pId);
        //}

        //public IEnumerable<IAdjunto> ObtenerAdjuntoTodos(string pCodigo = null)
        //{
        //    return this.iRepositorioAdjunto.ObtenerTodos(pCodigo);
        //}

        //public void Agregar(IAdjunto pEntidad)
        //{
        //    this.iRepositorioAdjunto.Agregar(pEntidad);
        //}

        //public void Eliminar(IAdjunto pEntidad)
        //{
        //    this.iRepositorioAdjunto.Eliminar(pEntidad);
        //} 
        //#endregion
    }
}
