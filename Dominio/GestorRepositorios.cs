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

            Repositorios.Add(typeof(Adjunto), new RepositorioAdjunto(pUoW.ObtenerRepositorio<Adjunto>(),this));
            Repositorios.Add(typeof(Cuenta), new RepositorioCuenta(pUoW.ObtenerRepositorio<Cuenta>(), this));
            Repositorios.Add(typeof(DireccionCorreo), new RepositorioDireccion(pUoW.ObtenerRepositorio<DireccionCorreo>(), this));
            Repositorios.Add(typeof(Mensaje), new RepositorioMensaje(pUoW.ObtenerRepositorio<Mensaje>(), this));
        }

        public IRepositorioUnico<T> ObtenerRepositorio<T>() where T : class
        {
            return (IRepositorioUnico<T>)this.Repositorios[typeof(T)]; 
        }
    }
}
