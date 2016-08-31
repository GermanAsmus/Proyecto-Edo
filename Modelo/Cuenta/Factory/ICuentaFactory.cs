using CapaInterfaces.Modelo;

namespace Modelo
{
    public interface ICuentaFactory
    {
        IServidorDTO AgregarServidor(string pNombre);
    }
}