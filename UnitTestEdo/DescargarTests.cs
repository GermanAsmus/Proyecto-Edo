using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using Servicio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Tests
{
    [TestClass()]
    public class DescargarTestsDescargar
    {
        [TestMethod()]
        public void DescargarAdjuntoTest()
        {
            MemoryStream stream = new MemoryStream();
            File.OpenRead(@"C:\Users\german\Documents\myGrammarLenguageSImple.txt").CopyTo(stream);
            InfoAdjunto adjunto = new InfoAdjunto() { Nombre = "myGrammarLenguageSImple.txt", Contenido = stream.ToArray() };
            var resultado = Descargar.DescargarAdjunto(new List<InfoAdjunto>() { adjunto });
            Assert.AreEqual(resultado.Count, 1);
        }

        [TestMethod()]
        public void DescargarTextoPlanoTest()
        {
            Completo mensaje = new Completo()
            {
                Fecha = DateTime.Now.ToLongDateString(),
                Asunto = "UnitTest",
                DireccionCorreo = new DireccionCorreo() { DireccionId = "unitTest@testing.com" },
                Contenido = "Contenido del Mensaje...",
                Destinatario = new List<DireccionCorreo>()
                {
                    new DireccionCorreo() { DireccionId = "unitTestFirend@testing.com" },
                    new DireccionCorreo() { DireccionId = "unitTestMom@testing.com" }
                }
        };
            var resultado = Descargar.DescargarTextoPlano(mensaje);
            Assert.IsNotNull(resultado);
        }

        [TestMethod()]
        public void DescargarMensajeTest()
        {
            Completo mensaje = new Completo()
            {
                Fecha = DateTime.Now.ToLongDateString(),
                Asunto = "UnitTest",
                DireccionCorreo = new DireccionCorreo() { DireccionId = "unitTest@testing.com" },
                Contenido = "Contenido del Mensaje...",
                Destinatario = new List<DireccionCorreo>()
                {
                    new DireccionCorreo() { DireccionId = "unitTestFirend@testing.com" },
                    new DireccionCorreo() { DireccionId = "unitTestMom@testing.com" }
                }
            };
            var resultado = Descargar.DescargarMensaje(mensaje);
            Assert.IsNotNull(resultado);
        }
    }
}