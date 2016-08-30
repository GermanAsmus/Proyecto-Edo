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

        protected override IServidor CrearServidor()
        {
            IServidorFactory servidorFactory = new ServidorYahooFactory();
            return new ServidorYahoo(servidorFactory);
        }
    }
}