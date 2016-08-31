namespace CapaInterfaces.Modelo
{
    public interface IProtocoloDTO : IEntidadModelo
    {
        string Nombre { get; }
        //Host del servidor.
        string Host { get; }
        //Puerto del servidor.
        int Puerto { get; }
        //SSL, capa de puertos de seguridad, del servidor.
        bool SSL { get; }
    }
}