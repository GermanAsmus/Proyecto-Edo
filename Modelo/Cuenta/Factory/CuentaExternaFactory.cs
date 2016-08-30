using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CuentaExternaFactory : ICuentaFactory
    {
        public IServidor AgregarServidor(string pNombre)
        {
            CreadorServidor creador = new CreadorServidorNulo();
            IServidor servidorNulo = creador.ObtenerServidor();
            return servidorNulo;
        }
    }
}