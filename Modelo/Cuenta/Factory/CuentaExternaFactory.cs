using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CuentaExternaFactory : ICuentaFactory
    {
        public IServidorDTO AgregarServidor(string pNombre)
        {
            CreadorServidor creador = new CreadorServidorNulo();
            IServidorDTO servidorNulo = creador.ObtenerServidor();
            return servidorNulo;
        }
    }
}