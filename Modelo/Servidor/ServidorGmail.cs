using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorGmail : ServidorDAO
    {
        public ServidorGmail(ServidorFactory pServidorFactory) : base(pServidorFactory)
        {
            this.ServidorDTO.Nombre = "gmail";
        }
    }
}