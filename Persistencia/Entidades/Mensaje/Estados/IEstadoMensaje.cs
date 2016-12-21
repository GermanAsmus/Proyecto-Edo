namespace Persistencia.Entidades.Mensaje.Estados
{
    public interface IEstadoMensaje
    {
        string ObtenerEstado();
        void CambiarEstado();
    }
}