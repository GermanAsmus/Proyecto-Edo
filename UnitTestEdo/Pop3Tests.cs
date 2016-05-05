using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using Utilidades;

namespace Servicio.Tests
{
    [TestClass()]
    public class Pop3TestsPop3
    {
        [TestMethod]
        public void Descargar()
        {
            Servidor gmail = new Servidor()
            {
                Nombre = "gmail",
                HostSMTP = "smtp.gmail.com",
                HostPOP = "pop.gmail.com",
                PuertoPOP = 995,
                PuertoSMTP = 587,
                SSL = true
            };

            DireccionCorreo dieccion = new DireccionCorreo()
            {
                DireccionDeCorreo = "electronik.32@gmail.com"
            };

            Cuenta cuenta = new Cuenta()
            {
                DireccionCorreo = dieccion,
                Contraseña = "proyecto3ro",
                Nombre = "German Asmus",
                Servidor = gmail,
            };

            Pop3 popClient = new Pop3(cuenta, new Buzon());
            popClient.ActualizacionBuzon += Fin;
            popClient.Descargar(10);
            
            CollectionAssert.AllItemsAreNotNull(popClient.Buzon.Cabeceras);
        }
        private void Fin()
        {
            //Se descargaron los mensajes
        }
    }
}