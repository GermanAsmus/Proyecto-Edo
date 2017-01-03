using EdoUI.Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dominio.Persistencia
{
     public interface IControladorPersistencia
    {
        int Actualizar();

        #region manejo de cuenta
        ICuentaDTO ObtenerCuenta(int? pId);

        ICuentaDTO ObtenerCuenta(string pNombre = null);

        IEnumerable<ICuentaDTO> ObtenerCuentaSegun(int? pId);

        IEnumerable<ICuentaDTO> ObtenerCuentaSegun(string pNombre = null);

        void Agregar(ICuentaDTO pEntidad);

        void Eliminar(ICuentaDTO pEntidad);

        #endregion

        #region manejo de direccion de correo
        IDireccionCorreoDTO ObtenerCuentaDireccionDeCorreo(int? pId);

        IDireccionCorreoDTO ObtenerCuentaDireccionDeCorreo(string pDireccion);

        IEnumerable<IDireccionCorreoDTO> ObtenerCuentaDireccionDeCorreoSegun(int? pId);

        IEnumerable<IDireccionCorreoDTO> ObtenerCuentaDireccionDeCorreoSegun(string pDireccion);

        void Agregar(IDireccionCorreoDTO pEntidad);

        void Eliminar(IDireccionCorreoDTO pEntidad);

        #endregion

        #region manejo de mensajes
        IMensajeDTO ObtenerMensaje(int? pId);

        IMensajeDTO ObtenerMensaje(string pAsunto = null);

        IEnumerable<IMensajeDTO> ObtenerMensajeSegun(int? pId);

        IEnumerable<IMensajeDTO> ObtenerMensajeSegun(string Asunto = null);

        void Agregar(IMensajeDTO pEntidad);

        void Eliminar(IMensajeDTO pEntidad);

        #endregion

        #region manejo de adjuntos
        IAdjuntoDTO ObtenerAdjunto(int pId);

        IAdjuntoDTO ObtenerAdjunto(string pCodigo);

        IEnumerable<IAdjuntoDTO> ObtenerAdjuntoSegun(int? pId);

        IEnumerable<IAdjuntoDTO> ObtenerAdjuntoSegun(string pCodigo = null);

        void Agregar(IAdjuntoDTO pEntidad);

        void Eliminar(IAdjuntoDTO pEntidad);
        #endregion
    }
}
