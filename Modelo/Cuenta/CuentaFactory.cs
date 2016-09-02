using CapaInterfaces;
using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System;

namespace Modelo
{
    public class CuentaFactory : Factory<IServidorDAO>
    {
        protected IDictionary<string, ICreador<IServidorDAO>> Creadores;
        private string iNombreCreadoresServidor;
        public CuentaFactory(string pNombreCreadoresServidores) : base()
        {
            this.Creadores = new ControlCreadoresServidor().ObtenerCreadores();
            this.iNombreCreadoresServidor = pNombreCreadoresServidores;
        }
        public override IServidorDAO AgregarEntidad()
        {
            IServidorDAO servidor = null;
            try
            {
                servidor = this.Creadores[iNombreCreadoresServidor].ObtenerEntidad();
            }
            catch (KeyNotFoundException)
            {
                CreadorServidor creador = new CreadorServidorNulo();
                servidor = creador.ObtenerEntidad();
            }

            return servidor;
        }
    }
}