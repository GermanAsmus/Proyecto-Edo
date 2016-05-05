using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using Utilidades;

namespace Dominio
{
    public class Controlador : IControlador
    {
        private IGestorRespositorios iGestorRepositorios;
        private IServicio iServicio;

        public Controlador(IUnitOfWork pUnitOfWork, IServicio pServicio)
        {
            iGestorRepositorios = new GestorRepositorios(pUnitOfWork);
            iServicio = pServicio;
        }
        
        public int AregarCuenta(Cuenta pCuenta, Servidor pServidor)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.Agregar(pCuenta, pServidor);
        }
        public int EditarCuenta(Cuenta pCuenta)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.Editar(pCuenta);
        }
        public int EditarDireccionDeCorreo(DireccionCorreo pDireccionCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            return aRepositorio.Editar(pDireccionCorreo);
        }
        public int EliminarDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = this.ObtenerDireccionDeCorreo(pId);
            return aRepositorio.Eliminar(unaDireccion);
        }
        public int EliminarDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = this.ObtenerDireccionDeCorreo(pDireccionDeCorreo);
            return aRepositorio.Eliminar(unaDireccion);
        }
        public DireccionCorreo ObtenerDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorCuentaId(x, pId));
            if (unaDireccion == null)
                throw new Exception("No existe la direccion de correo en la bd");
            return unaDireccion;
        }
        public DireccionCorreo ObtenerDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorDireccion(x, pDireccionDeCorreo));
            if (unaDireccion == null)
                throw new Exception("No existe la direccion de correo en la bd");
            return unaDireccion;
        }
        public IEnumerable<DireccionCorreo> ObtenerTodasLasDireccionesDeCorreo()
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            return aRepositorio.ObtenerTodos();
        }
        public int EliminarMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = this.ObtenerMensaje(pId);
            return aRepositorio.Eliminar(unMensaje);
        }
        public int EliminarMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = this.ObtenerMensaje(pAsunto);
            return aRepositorio.Eliminar(unMensaje);
        }
        public Mensaje ObtenerMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorId(x, pId));
            if (unMensaje == null)
                throw new Exception("el mensaje no existe en la bd");
            return unMensaje;
        }
        public Mensaje ObtenerMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorAsunto(x, pAsunto));
            if (unMensaje == null)
                throw new Exception("el mensaje no existe en la bd");
            return unMensaje;
        }
        public IEnumerable<Mensaje> ObtenerTodosLosMensajes()
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            return aRepositorio.ObtenerTodos();
        }
        public int EliminarCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = this.ObtenerCuenta(pId);
            return aRepositorio.Eliminar(unaCuenta);
        }
        public int EliminarCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = this.ObtenerCuenta(pNombre);
            return aRepositorio.Eliminar(unaCuenta);
        }
        public Cuenta ObtenerCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorId(x, pId));
            if (unaCuenta == null)
                throw new Exception("la cuenta no existe en la bd");
            return unaCuenta;
        }
        public Cuenta ObtenerCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorNombre(x, pNombre));
            if (unaCuenta == null)
                throw new Exception("la cuenta no existe en la bd");
            return unaCuenta;
        }
        public IEnumerable<Cuenta> ObtenerTodasLasCuentas()
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.ObtenerTodos();
        }
        public void Enviar(Mensaje pMensaje, Cuenta pCuenta, IProtocoloTransmision pProtocoloTransmision)
        {
            this.iServicio.CuentaServicio = pCuenta;
            this.iServicio.Enviar(pMensaje, pProtocoloTransmision);
        }
        public void Recibir(int pCantidad, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion, IBuzon pBuzon)
        {
            this.iServicio.CuentaServicio = pCuenta;
            this.iServicio.Descargar(pCantidad, pProtocoloRecepcion, pBuzon);
        }
        public void EliminarDelServidor(int pId, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion)
        {
            this.iServicio.CuentaServicio = pCuenta;
            this.iServicio.Eliminar(pId, pProtocoloRecepcion);
        }
    }
}
