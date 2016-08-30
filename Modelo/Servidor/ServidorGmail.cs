using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorGmail : Servidor
    {
        public ServidorGmail(IServidorFactory pServidorFactory) : base(pServidorFactory)
        {
            this.Nombre = "gmail";
        }
    }
}