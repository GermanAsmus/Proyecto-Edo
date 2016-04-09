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
        public ValidarDireccionCorreo(IServicio<DireccionCorreo> pServicio):base(pServicio)
        {

        }

        public override DireccionCorreo Evaluar(DireccionCorreo entidad)
        {
            if (string.IsNullOrEmpty(entidad.DireccionId))
                throw new NullReferenceException("direccionId");

            var resultado = this.Servicio.Obtener(x => x.DireccionId == entidad.DireccionId);

            if (resultado != null)
                return resultado;
            else
                try
                {
                    MailAddress auxiliar = new MailAddress(entidad.DireccionId);
                    return entidad;
                }
                catch (FormatException)
                {
                    throw new FormatException("El formato de la direccion de correo no es valida");
                }
        }
    }
}
