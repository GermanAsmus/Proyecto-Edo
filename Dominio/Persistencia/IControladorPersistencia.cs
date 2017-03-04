using Dominio.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dominio.Persistencia
{
     public interface IControladorPersistencia
    {
        int Actualizar();

        #region manejo de cuenta
        ICuentaDeUsuario ObtenerCuenta(int? pId);

        ICuentaDeUsuario ObtenerCuenta(string pNombre = null);

        IEnumerable<ICuentaDeUsuario> ObtenerCuentaTodos(int? pId);

        IEnumerable<ICuentaDeUsuario> ObtenerCuentaTodos(string pNombre = null);

        void Agregar(ICuentaDeUsuario pEntidad);

        void Eliminar(ICuentaDeUsuario pEntidad);

        #endregion

        #region manejo de direccion de correo
        IDireccionCorreo ObtenerCuentaDireccionDeCorreo(int? pId);

        IDireccionCorreo ObtenerCuentaDireccionDeCorreo(string pDireccion);

        IEnumerable<IDireccionCorreo> ObtenerCuentaDireccionDeCorreoTodos(int? pId);

        IEnumerable<IDireccionCorreo> ObtenerCuentaDireccionDeCorreoTodos(string pDireccion);

        void Agregar(IDireccionCorreo pEntidad);

        void Eliminar(IDireccionCorreo pEntidad);

        #endregion

        #region manejo de mensajes
        IMensaje ObtenerMensaje(int? pId);

        IMensaje ObtenerMensaje(string pAsunto = null);

        IEnumerable<IMensaje> ObtenerMensajeTodos(int? pId);

        IEnumerable<IMensaje> ObtenerMensajeTodos(string Asunto = null);

        void Agregar(IMensaje pEntidad);

        void Eliminar(IMensaje pEntidad);

        #endregion
    }
}
