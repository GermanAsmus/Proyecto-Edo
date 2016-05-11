using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Mail;
using ControlDependencia.Persistencia;
using ControlDependencia.Dominio;

namespace Dominio
{
    public class GestorRepositorios : IGestorRespositorios
    {
        public IDictionary<Type, IRepositorioRaiz> Repositorios { get; }
        /// <summary>
        /// Constructor del GestorRepositorios.
        /// Se instancian los repositorios y se los agregan al disccionario Repositorios.
        /// </summary>
        /// <param name="pUoW">Unit of Work</param>
        public GestorRepositorios(IUnitOfWork pUoW)
        {
            Repositorios = new Dictionary<Type, IRepositorioRaiz>();

            Repositorios.Add(typeof(Adjunto), new RepositorioAdjunto(pUoW.RepositorioAdjunto,this));
            Repositorios.Add(typeof(Cuenta), new RepositorioCuenta(pUoW.RepositorioCuenta,this));
            Repositorios.Add(typeof(DireccionCorreo), new RepositorioDireccion(pUoW.RepositorioDireccionCorreo,this));
            Repositorios.Add(typeof(Mensaje), new RepositorioMensaje(pUoW.RepositorioMensaje,this));
            Repositorios.Add(typeof(Servidor), new RepositorioServidor(pUoW.RepositorioServidor,this));
        }

        public IRepositorio<T> ObtenerRepositorio<T>() where T : class
        {
            return (IRepositorio<T>)this.Repositorios[typeof(T)]; 
        }
    }
}
