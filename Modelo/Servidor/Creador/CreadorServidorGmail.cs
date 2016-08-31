using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorServidorGmail : CreadorServidor
    {
        public override string ObtenerNombre()
        {
            return "gmail";
        }

        protected override IServidorDTO CrearServidor()
        {
            IServidorFactory servidorFactory = new ServidorGmailFactory();
            return new ServidorGmail(servidorFactory).ServidorDTO;
        }
    }
}