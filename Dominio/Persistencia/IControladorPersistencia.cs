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
        ICuenta ObtenerCuenta(int? pId);

        ICuenta ObtenerCuenta(string pNombre = null);

        IEnumerable<ICuenta> ObtenerCuentaSegun(int? pId);

        IEnumerable<ICuenta> ObtenerCuentaSegun(string pNombre = null);

        void Agregar(ICuenta pEntidad);

        void Eliminar(ICuenta pEntidad);

        #endregion

        #region manejo de direccion de correo
        IDireccionCorreo ObtenerCuentaDireccionDeCorreo(int? pId);

        IDireccionCorreo ObtenerCuentaDireccionDeCorreo(string pDireccion);

        IEnumerable<IDireccionCorreo> ObtenerCuentaDireccionDeCorreoSegun(int? pId);

        IEnumerable<IDireccionCorreo> ObtenerCuentaDireccionDeCorreoSegun(string pDireccion);

        void Agregar(IDireccionCorreo pEntidad);

        void Eliminar(IDireccionCorreo pEntidad);

        #endregion

        #region manejo de mensajes
        IMensaje ObtenerMensaje(int? pId);

        IMensaje ObtenerMensaje(string pAsunto = null);

        IEnumerable<IMensaje> ObtenerMensajeSegun(int? pId);

        IEnumerable<IMensaje> ObtenerMensajeSegun(string Asunto = null);

        void Agregar(IMensaje pEntidad);

        void Eliminar(IMensaje pEntidad);

        #endregion

        #region manejo de adjuntos
        IAdjunto ObtenerAdjunto(int pId);

        IAdjunto ObtenerAdjunto(string pCodigo);

        IEnumerable<IAdjunto> ObtenerAdjuntoSegun(int? pId);

        IEnumerable<IAdjunto> ObtenerAdjuntoSegun(string pCodigo = null);

        void Agregar(IAdjunto pEntidad);

        void Eliminar(IAdjunto pEntidad);
        #endregion
    }
}
