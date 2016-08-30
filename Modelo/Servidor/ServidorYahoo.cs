using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorYahoo : Servidor
    {
        public ServidorYahoo(IServidorFactory pServidorFactory) : base (pServidorFactory)
        {
            this.Nombre = "yahoo";
        }
    }
}