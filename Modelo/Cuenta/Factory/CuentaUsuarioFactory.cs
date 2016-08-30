using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class CuentaUsuarioFactory : ICuentaFactory
    {
        private IDictionary<string, CreadorServidor> Creadores;
        public CuentaUsuarioFactory()
        {
            this.Creadores = new ControlCreadoresServidor().ObtenerCreadores();
        }
        public IServidor AgregarServidor(string pNombre)
        {
            IServidor servidor = null;
            try
            {
                servidor = this.Creadores[pNombre].ObtenerServidor();
            }
            catch (KeyNotFoundException)
            {
                CreadorServidor creador = new CreadorServidorNulo();
                servidor = creador.ObtenerServidor();
            }

            return servidor;
        }
    }
}