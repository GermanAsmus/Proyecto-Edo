using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorNulo : Servidor
    {

        public ServidorNulo(IServidorFactory pServidorFactory) : base (pServidorFactory)
        {
            this.Nombre = "nulo";
        }
    }
}