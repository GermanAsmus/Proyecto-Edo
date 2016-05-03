using Modelo;

namespace ControlDependencia
{
    public interface IServicio
    {
        Cuenta CuentaServicio { get; }
        IBuzon BuzonServicio { get; }

        void Enviar(Mensaje pMensaje,string pNombreProtocolo);
        void Descargar(int pCantidad,string pNombreProtocolo);
        void Eliminar(int pUid,string pNombreProtocolo);
    }
}
