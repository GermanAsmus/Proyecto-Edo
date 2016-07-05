using ControlDependencia;
using ControlDependencia.Dominio;
using ControlDependencia.Persistencia;
using ControlDependencia.Servicio;
using ControlDependencia.Utilidades;
using EdoUnity;
using Modelo;
using System;
using System.Collections.Generic;
using Utilidades;
using Utilidades.CriteriosDeBusqueda;

namespace Dominio
{
    public class Controlador : IControlador
    {
        public IGestorRespositorios GestorRepositorios { get; }
        private IServicio iServicio;

        public Controlador(IUnitOfWork pUnitOfWork)
        {
            iServicio = IoCContainer.Resolver<IServicio>();
            GestorRepositorios = new GestorRepositorios(pUnitOfWork);
        }

        public int AregarCuenta(Cuenta pCuenta, Servidor pServidor)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.Agregar(pCuenta, pServidor);
        }
        public int EditarCuenta(Cuenta pCuenta)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.Editar(pCuenta);
        }
        public int EditarDireccionDeCorreo(DireccionCorreo pDireccionCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            return aRepositorio.Editar(pDireccionCorreo);
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
            IProtocoloTransmision iProtocoloTransmision = IoCContainer.Resolver<IProtocoloTransmision>();
            this.iServicio.Enviar(pMensaje, pCuenta, iProtocoloTransmision);
        }
        public void Recibir(int pCantidad, Cuenta pCuenta, IBuzon pBuzon)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoCContainer.Resolver<IProtocoloRecepcion>();
            this.iServicio.Descargar(pCantidad, pCuenta, iProtocoloRecepcion, pBuzon);
        }
        public void EliminarDelServidor(int pId, Cuenta pCuenta)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoCContainer.Resolver<IProtocoloRecepcion>();
            this.iServicio.Eliminar(pId, pCuenta, iProtocoloRecepcion);
        }
        public int AregarCuenta(DireccionCorreo pDireccion, Cuenta pCuenta, Servidor pServidor)
        {
            throw new NotImplementedException();
        }
        public Servidor ObtenerServidor(int pId)
        {
            throw new NotImplementedException();
        }
        public Servidor ObtenerServidor(string pNombre)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Servidor> ObtenerTodosLosServidores()
        {
            throw new NotImplementedException();
        }
    }
}
