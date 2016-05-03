using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Tests
{
    [TestClass()]
    public class SmtpTestsSmtp
    {
       // static Servidor gmail = new Servidor()
       // {
       //     Nombre = "gmail",
       //     HostSMTP = "smtp.gmail.com",
       //     HostPOP = "pop.gmail.com",
       //     PuertoPOP = 995,
       //     PuertoSMTP = 587,
       //     SSL = true

       // };

       // static Cuenta cuenta = new Cuenta()
       // {
       //     DireccionId =  "electronik.32@gmail.com" ,
       //     Contraseña = "proyecto3ro",
       //     CuentaId = "German Asmus",
       //     Servidor = gmail,
       //     //ServidorNombre = gmail.Nombre
       // };

       // Completo mensaje = new Completo()
       // {
       //     Fecha = DateTime.Now.ToLongDateString(),
       //     Asunto = "UnitTest",
       //     DireccionCorreo = new DireccionCorreo() { DireccionId = cuenta.DireccionId },
       //     Contenido = "Contenido del Mensaje...",
       //     Destinatario = new List<DireccionCorreo>()
       //         {
       //             new DireccionCorreo() { DireccionId = "germanasmusmaher@gmail.com" }
       //         }
       // };

       //[TestMethod()]
       // public void EnviarTest()
       // {
       //     try
       //     {
       //         Smtp smtpClient = new Smtp(cuenta);
       //         smtpClient.Enviar(mensaje);
       //         Assert.IsTrue(true);
       //     }
       //     catch (ApplicationException anException)
       //     {
       //         Assert.Fail(anException.Message, anException.StackTrace);
       //     }
       // }
    }
}