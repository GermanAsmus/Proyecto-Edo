using CapaInterfaces.Modelo;

namespace Modelo
{
    public interface ICuentaFactory
    {
        IServidor AgregarServidor(string pNombre);
    }
}