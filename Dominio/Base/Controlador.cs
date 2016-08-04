using ControlDependencia;
using ControlDependencia.Dominio;
using ControlDependencia.Persistencia;
using ControlDependencia.Servicio;
using ControlDependencia.Utilidades;
using Modelo;
using System;
using System.Collections.Generic;
using Utilidades.CriteriosDeBusqueda;
using UnityDI;
using System.Threading;
using Dominio.Repositorios;

namespace Dominio.Base
{
    public class Controlador : IControlador
    {
        public IGestorRespositorios GestorRepositorios { get; private set; }
        private IServicio iServicio;

        public Controlador(IUnitOfWork pUnitOfWork)
        {
            iServicio = IoCContainer.Resolver<IServicio>();
            GestorRepositorios = new GestorRepositorios(pUnitOfWork);
        }
        public int AregarCuenta(DireccionCorreo pDireccion, Cuenta pCuenta)
        {
            IRepositorioUnico<Cuenta> aRepositorioCuenta = this.GestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorioCuenta.Agregar(pCuenta);
        }
        public int EditarCuenta(Cuenta pCuenta)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.Editar();
        }
        public int EditarDireccionDeCorreo(DireccionCorreo pDireccionCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            return aRepositorio.Editar();
        }
        public int EliminarDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = this.ObtenerDireccionDeCorreo(pId);
            return aRepositorio.Eliminar(unaDireccion);
        }
        public int EliminarDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = this.ObtenerDireccionDeCorreo(pDireccionDeCorreo);
            return aRepositorio.Eliminar(unaDireccion);
        }
        public DireccionCorreo ObtenerDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorCuentaId(x, pId));
            if (unaDireccion == null)
                throw new Exception("La direccion de correo no existe en el sistema");
            return unaDireccion;
        }
        public DireccionCorreo ObtenerDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorDireccion(x, pDireccionDeCorreo));
            if (unaDireccion == null)
                throw new Exception("La direccion de correo no existe en el sistema");
            return unaDireccion;
        }
        public IEnumerable<DireccionCorreo> ObtenerTodasLasDireccionesDeCorreo()
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            return aRepositorio.ObtenerTodos();
        }
        public int EliminarMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = this.ObtenerMensaje(pId);
            return aRepositorio.Eliminar(unMensaje);
        }
        public int EliminarMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = this.ObtenerMensaje(pAsunto);
            return aRepositorio.Eliminar(unMensaje);
        }
        public Mensaje ObtenerMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorId(x, pId));
            if (unMensaje == null)
                throw new Exception("El menasje no existe en el sistema");
            return unMensaje;
        }
        public Mensaje ObtenerMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorAsunto(x, pAsunto));
            if (unMensaje == null)
                throw new Exception("El menasje no existe en el sistema");
            return unMensaje;
        }
        public IEnumerable<Mensaje> ObtenerTodosLosMensajes()
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<Mensaje>();
            return aRepositorio.ObtenerTodos();
        }
        public int EliminarCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = this.ObtenerCuenta(pId);
            return aRepositorio.Eliminar(unaCuenta);
        }
        public int EliminarCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = this.ObtenerCuenta(pNombre);
            return aRepositorio.Eliminar(unaCuenta);
        }
        public Cuenta ObtenerCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorId(x, pId));
            if (unaCuenta == null)
                throw new Exception("La cuenta no existe en el sistema");
            return unaCuenta;
        }
        public Cuenta ObtenerCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorNombre(x, pNombre));
            if (unaCuenta == null)
                throw new Exception("La cuenta no existe en el sistema");
            return unaCuenta;
        }
        public IEnumerable<Cuenta> ObtenerTodasLasCuentas()
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.ObtenerTodos();
        }
        public void Enviar(Mensaje pMensaje, Cuenta pCuenta)
        {
            //poner un estado de enviado o no enviado(por las dudas)

            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

            if (pCuenta == null)
                throw new ArgumentNullException(nameof(pCuenta));

            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(pMensaje.Asunto))
                throw new NullReferenceException("El asunto del mensaje no puede ser vacío o nulo");

            //verifica cada una de las direcciones de correo
            List<DireccionCorreo> destinatariosValidos = new List<DireccionCorreo>();
            var destinatarios = pMensaje.Destinatario.GetEnumerator();

            IRepositorioUnico<DireccionCorreo> aRepositorioDireccionCorreo = this.GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo iDireccion = null;
            while (destinatarios.MoveNext())
            {
                iDireccion = aRepositorioDireccionCorreo.Obtener(d => BuscarDireccionDeCorreo.BuscarPorDireccion(d, destinatarios.Current.DireccionDeCorreo));
                if (iDireccion != null)
                    destinatariosValidos.Add(destinatarios.Current);
            }
            pMensaje.Destinatario = destinatariosValidos;

            IRepositorioUnico<Cuenta> aRepositorioCuenta = this.GestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta iCuenta = aRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, pCuenta.Id));
            if (iCuenta == null)
                throw new NullReferenceException(nameof(iCuenta));

            iCuenta.Mensajes.Add(pMensaje);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            pMensaje.CuentaId = iCuenta.Id;
            //Se actualiza la cuenta, que mantiene una colección de mensajes.
            aRepositorioCuenta.Editar();

            IProtocoloTransmision iProtocoloTransmision = IoCContainer.Resolver<IProtocoloTransmision>();
            this.iServicio.Enviar(pMensaje, pCuenta, iProtocoloTransmision);
        }
        public void Recibir(CancellationToken pCancellation,Cuenta pCuenta, ref IBuzon pBuzon)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoCContainer.Resolver<IProtocoloRecepcion>();
            this.iServicio.Descargar(pCancellation, pCuenta, iProtocoloRecepcion, ref pBuzon);
        }
        public void Recibir(int pIdMensaje, CancellationToken pCancellation, Cuenta pCuenta,ref IBuzon pBuzon)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoCContainer.Resolver<IProtocoloRecepcion>();
            this.iServicio.Descargar(pIdMensaje, pCancellation, pCuenta, iProtocoloRecepcion,ref pBuzon);
        }
        public void EliminarDelServidor(int pId, Cuenta pCuenta)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoCContainer.Resolver<IProtocoloRecepcion>();
            this.iServicio.Eliminar(pId, pCuenta, iProtocoloRecepcion);
        }

    }
}
