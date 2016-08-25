namespace CapaInterfaces.Modelo
{
    public interface IProtocolo
    {
        string Nombre { get; }
        //Host del servidor.
        string Host { get; set; }
        //Puerto del servidor.
        int Puerto { get; set; }
        //SSL, capa de puertos de seguridad, del servidor.
        bool SSL { get; set; }
    }
}