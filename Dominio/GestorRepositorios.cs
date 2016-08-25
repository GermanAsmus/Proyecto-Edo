using CapaInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Mail;
using CapaInterfaces.Persistencia;
using CapaInterfaces.Dominio;
using Dominio.Repositorios;
using CapaInterfaces.Modelo;

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
            Repositorios.Add(typeof(IDireccionCorreo), new RepositorioDireccion(pUoW.ObtenerRepositorio<IDireccionCorreo>()));
            
            //Repositorios.Add(typeof(Adjunto), new RepositorioAdjunto(pUoW.ObtenerRepositorio<Adjunto>(),this));
            Repositorios.Add(typeof(ICuenta), new RepositorioCuenta(pUoW.ObtenerRepositorio<ICuenta>(),this.ObtenerRepositorio<IDireccionCorreo>()));

            Repositorios.Add(typeof(IMensaje), new RepositorioMensaje(pUoW.ObtenerRepositorio<IMensaje>(), this.ObtenerRepositorio<IDireccionCorreo>(), this.ObtenerRepositorio<ICuenta>()));
        }

        public IRepositorioCompleto<T> ObtenerRepositorio<T>() where T : class
        {
            return (IRepositorioCompleto<T>)this.Repositorios[typeof(T)]; 
        }
    }
}
