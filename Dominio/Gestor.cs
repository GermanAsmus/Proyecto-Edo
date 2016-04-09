using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Mail;

namespace Dominio
{
    public class Gestor : IGestor
    {
        private IDictionary<Type, IServicioRaiz> Servicios { get; }

        public IList<IValidar> Validadores { get; set; }

        public Gestor(IUnitOfWork pUoW, IList<IValidar> pValidadores)
        {
            Servicios = new Dictionary<Type, IServicioRaiz>();

            Servicios.Add(typeof(Adjunto), new RepositorioBaseAdjunto(pUoW.RepositorioAdjunto) { /*EstrategiaAgregar = ...*/});
            Servicios.Add(typeof(Cuenta), new RepositorioBaseCuenta(pUoW.RepositorioCuenta));
            Servicios.Add(typeof(DireccionCorreo), new RepositorioBaseDireccion(pUoW.RepositorioDireccionCorreo));
            Servicios.Add(typeof(Completo), new RepositorioBaseMensaje(pUoW.RepositorioMensaje));
            Servicios.Add(typeof(Servidor), new RepositorioBaseServidor(pUoW.RepositorioServidor));

            Validadores = new List<IValidar>(pValidadores.Count);
            
            pValidadores.ToList().ForEach(x => Validadores.Add(x));

            //Validadores.Add(typeof(Adjunto),new ValidarAdjunto((IServicio<Adjunto>)Servicios[typeof(Adjunto)]));
            //Validadores.Add(typeof(DireccionCorreo), new ValidarDireccionCorreo((IServicio<DireccionCorreo>)Servicios[typeof(DireccionCorreo)]));
            //Validadores.Add(typeof(Servidor), new ValidarServidor((IServicio<Servidor>)Servicios[typeof(Servidor)]));


        }
        public IServicioRaiz ObtenerServicio(Type tipo)
        {
            return Servicios[tipo];
        }


        //public Adjunto Validar(Adjunto adjunto)
        //{
        //    //El string no puede ser nulo o vacío
        //    if (string.IsNullOrEmpty(adjunto.AdjuntoId))
        //        throw new NullReferenceException("AdjuntoId");

        //    var aServicioadjunto = this.ObtenerServicio(typeof(Adjunto));
        //    var resultado = ((IServicio<Adjunto>)aServicioadjunto).Obtener(x => x.AdjuntoId == adjunto.AdjuntoId);
        //    if (resultado != null)
        //        return resultado;
        //    else if (File.Exists(adjunto.AdjuntoId))
        //        return adjunto;
        //    else
        //        throw new NullReferenceException("AdjuntoId");
        //}
        //public DireccionCorreo Validar(DireccionCorreo direccion)
        //{
        //    if (string.IsNullOrEmpty(direccion.DireccionId))
        //        throw new NullReferenceException("direccionId");

        //    var aServicioDireccion = this.ObtenerServicio(typeof(DireccionCorreo));
        //    var resultado = ((IServicio<DireccionCorreo>)aServicioDireccion).Obtener(x => x.DireccionId == direccion.DireccionId);

        //    if (resultado != null)
        //        return resultado;
        //    else
        //        try
        //        {
        //            MailAddress auxiliar = new MailAddress(direccion.DireccionId);
        //            return direccion;
        //        }
        //        catch (FormatException)
        //        {
        //            throw new FormatException("El formato de la direccion de correo no es valida");
        //        }
        //}
        //public Servidor Validar(Servidor servidor)
        //{
        //    var aServicioServidor = this.ObtenerServicio(typeof(Servidor));
        //    var resultado = ((IServicio<Servidor>)aServicioServidor).Obtener(x => x.Nombre == servidor.Nombre);
        //    if (resultado != null)
        //        throw new ApplicationException("No existe el servidor");
        //    else
        //        return resultado;
        //}
    }
}
