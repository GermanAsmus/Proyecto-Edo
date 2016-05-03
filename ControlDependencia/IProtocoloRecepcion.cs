using Modelo;

namespace ControlDependencia
{
    public interface IProtocoloRecepcion
    {
        Cuenta CuentaUsuario { get; }
        IBuzon Buzon { get; }

        void Descargar(int pCantidad);
        void Eliminar(int pId);
    }
}
