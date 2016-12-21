using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorYahoo : ServidorDAO
    {
        public ServidorYahoo(ServidorFactory pServidorFactory) : base (pServidorFactory)
        {
            this.ServidorDTO.Nombre = "yahoo";
        }
    }
}