using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorYahoo : ServidorDAO
    {
        public ServidorYahoo(IServidorFactory pServidorFactory) : base (pServidorFactory)
        {
            this.ServidorDTO.Nombre = "yahoo";
        }
    }
}