using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorGmail : ServidorDAO
    {
        public ServidorGmail(IServidorFactory pServidorFactory) : base(pServidorFactory)
        {
            this.ServidorDTO.Nombre = "gmail";
        }
    }
}