using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using System.Collections.Generic;
using EdoUI.DTO;
using Persistencia.Entidades.Mensaje.Estados;
using Dominio.Entidades.DAO;
using Persistencia.Entidades.Mensaje;

namespace Tests
{
    [TestClass]
    public class MensajeTests
    {
        private static IMensajeDAO mensajeDAO;

        private static ICuentaDTO cuentaDTO;

        private static IMensajeDTO mensajeDTO;
        private static Mensajeria creador;

        [TestInitialize]
        public void Initialize()
        {
            mensajeDAO = null;

            creador = new Mensajeria();

            cuentaDTO = new CuentaUsuarioDTO() { DireccionCorreo = new DireccionCorreoDTO("tdd@gmail.com") };

            mensajeDTO = new MensajeDTO()
            {
                Asunto = "tdd",
            };
        }

        [TestMethod]
        public void ObtenerMensajeExterno()
        {
            ICuentaDTO cuentaDestinatario = new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino1@gmail.com") };

            (mensajeDTO as IMensajeCompletoDTO).Contenido = "contenido tdd";

            mensajeDAO = creador.CrearMensaje(cuentaDTO, "Asunto: tdd", cuentaDestinatario);
            Assert.AreEqual("tdd", mensajeDTO.Asunto);
        }

        [TestMethod]
        public void ObtenerEstadoVisibilidad_MensajeExterno()
        {
            ICuentaDTO cuentaDestinatario = new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino1@gmail.com") };
            mensajeDAO = creador.CrearMensaje(cuentaDTO, "Asunto: tdd", cuentaDestinatario);
            Assert.AreEqual(EstadoVisibilidad.No_Visto.ToString(), (mensajeDAO.MensajeDTO as MensajeDTO).Estado.ObtenerEstado());
        }

        [TestMethod]
        public void ObtenerMensajeCompletoUsuario()
        {
            ICollection<ICuentaDTO> destinatarios = new List<ICuentaDTO>()
            {
            new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino1@gmail.com") },
            new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino2@gmail.com") }
            };

            (cuentaDTO as ICuentaUsuarioDTO).Nombre = "vadim";
            (cuentaDTO as ICuentaUsuarioDTO).Contraseña = "contraseña";

            mensajeDAO = creador.CrearMensaje(cuentaDTO as ICuentaUsuarioDTO , "Asunto: tdd", destinatarios, "contenido tdd");

            Assert.AreEqual("contenido tdd", (mensajeDAO.MensajeDTO as IMensajeCompletoDTO).Contenido);
            Assert.AreEqual("vadim", ((mensajeDAO.MensajeDTO as IMensajeCompletoDTO).Cuenta as ICuentaUsuarioDTO).Nombre);
            Assert.AreEqual("destino1@gmail.com", (mensajeDAO.MensajeDTO as IMensajeCompletoDTO).Destinatario.ToList()[0].DireccionCorreo.DireccionDeCorreo);

            Assert.AreEqual("contenido tdd", (mensajeDAO.MensajeDTO as IMensajeCompletoDTO).Contenido);
        }

        [TestMethod]
        public void ObtenerEstadoComunicacion_MensajeUsuario()
        {
            ICollection<ICuentaDTO> destinatarios = new List<ICuentaDTO>()
            {
            new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino1@gmail.com") },
            new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino2@gmail.com") }
            };

            (cuentaDTO as ICuentaUsuarioDTO).Nombre = "vadim";
            (cuentaDTO as ICuentaUsuarioDTO).Contraseña = "contraseña";

            mensajeDAO = creador.CrearMensaje(cuentaDTO as ICuentaUsuarioDTO, "Asunto: tdd", destinatarios, "contenido tdd");

            Assert.AreEqual(EstadoComunicacion.No_Enviado.ToString(), (mensajeDAO.MensajeDTO as MensajeDTO).Estado.ObtenerEstado());

        }

        [TestMethod]
        public void AgregarNuevoDestinatario()
        {
            ICuentaDTO cuentaDestinatario = new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino1@gmail.com") };

            (mensajeDTO as IMensajeCompletoDTO).Contenido = "contenido tdd";

            mensajeDAO = creador.CrearMensaje(cuentaDTO, "Asunto: tdd", cuentaDestinatario);

            ICuentaDTO nuevaCuentaDestinatario = new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino2@gmail.com") };

            mensajeDAO.Agregar(nuevaCuentaDestinatario);

            Assert.IsNotNull(mensajeDAO.Obtener(x => x.DireccionCorreo.DireccionDeCorreo == "destino2@gmail.com"));
        }
        [TestMethod]
        public void EliminarDestinatario()
        {
            ICuentaDTO cuentaDestinatario = new CuentaDTO() { DireccionCorreo = new DireccionCorreoDTO("destino1@gmail.com") };

            (mensajeDTO as IMensajeCompletoDTO).Contenido = "contenido tdd";

            mensajeDAO = creador.CrearMensaje(cuentaDTO, "Asunto: tdd", cuentaDestinatario);
            
            mensajeDAO.Eliminar(x=> x.DireccionCorreo.DireccionDeCorreo=="destino1@gmail.com");

            Assert.IsNull(mensajeDAO.Obtener(x => x.DireccionCorreo.DireccionDeCorreo == "destino1@gmail.com"));
        }
    }
}
