using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ValidarDireccionCorreo : Validar<DireccionCorreo>
    {
        public ValidarDireccionCorreo(IServicio<DireccionCorreo> pServicio) : base(pServicio)
        {

        }

        public override async Task<DireccionCorreo> Evaluar(DireccionCorreo entidad)
        {
            if (string.IsNullOrEmpty(entidad.DireccionId))
                throw new NullReferenceException("direccionId");

            // var resultado =
            var direccion = await this.Servicio.Obtener(x => x.DireccionId == entidad.DireccionId);

            if (direccion != null)
                return direccion;
            else
                try
                {
                    MailAddress auxiliar = new MailAddress(entidad.DireccionId);
                    RepositorioBaseDireccion repositorio = (RepositorioBaseDireccion)Servicio;

                    await repositorio.Agregar(entidad);
                    return await repositorio.Obtener(x => x.DireccionId == entidad.DireccionId);
                }
                catch (FormatException)
                {
                    throw new FormatException("El formato de la direccion de correo no es valida");
                }

            //if (resultado != null)
            //    return resultado;
            //else
            //    try
            //    {
            //        MailAddress auxiliar = new MailAddress(entidad.DireccionId);
            //        return entidad;
            //    }
            //    catch (FormatException)
            //    {
            //        throw new FormatException("El formato de la direccion de correo no es valida");
            //    }
        }
    }
}
