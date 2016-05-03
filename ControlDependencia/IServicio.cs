using Modelo;

namespace ControlDependencia
{
    public interface IServicio
    {
        Cuenta CuentaServicio { get; }
        IBuzon BuzonServicio { get; }

        void Enviar(Mensaje mensaje);
        void Descargar(int cantidad);
        void Eliminar(int pUid);
    }
}
