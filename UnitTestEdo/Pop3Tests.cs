using ControlDependencia;
using ControlDependencia.Utilidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using Utilidades;
using Utilidades.Misc;

namespace Servicio.Tests
{
    [TestClass()]
    public class Pop3TestsPop3
    {
        [TestMethod]
        public void Descargar()
        {
            Servidor iServidorGmail = new Servidor()
            {
                Nombre = "gmail",
                HostSMTP = "smtp.gmail.com",
                HostPOP = "pop.gmail.com",
                PuertoPOP = 995,
                PuertoSMTP = 587,
                SSL = true
            };

            DireccionCorreo iDieccion = new DireccionCorreo()
            {
                DireccionDeCorreo = "electronik.32@gmail.com"
            };

            Cuenta iCuenta = new Cuenta()
            {
                DireccionCorreo = iDieccion,
                Contraseña = "proyecto3ro",
                Nombre = "German Asmus",
                Servidor = iServidorGmail,
            };

            IBuzon iBuzon = new Buzon();

            Pop3 popClient = new Pop3();
            popClient.Buzon = iBuzon;
            popClient.CuentaUsuario = iCuenta;
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