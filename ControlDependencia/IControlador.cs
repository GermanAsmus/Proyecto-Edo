using Modelo;
using System.Collections.Generic;

namespace ControlDependencia
{
    public interface IControlador
    {
        int AregarAdjunto(Adjunto pAdjunto, Mensaje pMensaje);
        int AregarCuenta(Cuenta pCuenta, Servidor pServidor);
        int AregarDireccionDeCorreo(DireccionCorreo pDireccionCorreo);
        int EditarCuenta(Cuenta pCuenta);
        int EditarDireccionDeCorreo(DireccionCorreo pDireccionCorreo);
        int EditarMensaje(Mensaje pMensaje);
        void EliminarMensajeDelServidorDeCorreo(ICriterio<Mensaje> pCriterio);
        int EliminarAdjunto(int pId);
        int EliminarAdjunto(string pCodigo);
        int EliminarDireccionDeCorreo(int pId);
        int EliminarDireccionDeCorreo(string pDireccionDeCorreo);
        DireccionCorreo ObtenerDireccionDeCorreo(int pId);
        DireccionCorreo ObtenerDireccionDeCorreo(string pDireccionDeCorreo);
        IEnumerable<DireccionCorreo> ObtenerTodasLasDireccionesDeCorreo();
        Adjunto ObtenerAdjunto(int pId);
        Adjunto ObtenerAdjunto(string pCodigo);
        IEnumerable<Adjunto> ObtenerTodosLosAdjuntos();
        int EliminarMensaje(int pId);
        int EliminarMensaje(string pAsunto);
        Mensaje ObtenerMensaje(int pId);
        Mensaje ObtenerMensaje(string pAsunto);
        IEnumerable<Mensaje> ObtenerTodosLosMensajes();
        int EliminarCuenta(int pId);
        int EliminarCuenta(string pNombre);
        Cuenta ObtenerCuenta(int pId);
        Cuenta ObtenerCuenta(string pNombre);
        IEnumerable<Cuenta> ObtenerTodasLasCuentas();
        void Enviar(Mensaje pMensaje, Cuenta pCuenta);
        void Recibir(Cuenta pCuenta);
        void EliminarDelServidor(int pId);
    }
}
