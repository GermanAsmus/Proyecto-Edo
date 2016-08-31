using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorServidorYahoo : CreadorServidor
    {
        public override string ObtenerNombre()
        {
            return "yahoo";
        }

        protected override IServidorDTO CrearServidor()
        {
            IServidorFactory servidorFactory = new ServidorYahooFactory();
            return new ServidorYahoo(servidorFactory).ServidorDTO;
        }
    }
}