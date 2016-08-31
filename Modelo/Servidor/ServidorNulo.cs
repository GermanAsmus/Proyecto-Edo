using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorNulo : ServidorDAO
    {

        public ServidorNulo(IServidorFactory pServidorFactory) : base (pServidorFactory)
        {
            this.ServidorDTO.Nombre = "nulo";
        }
    }
}