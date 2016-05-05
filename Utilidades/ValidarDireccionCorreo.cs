using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class ValidarDireccionCorreo : Validar<DireccionCorreo>
    {
        public override DireccionCorreo Evaluar(DireccionCorreo pEntidad, IRepositorio<DireccionCorreo> pRepositorio)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (string.IsNullOrEmpty(pEntidad.DireccionDeCorreo))
                throw new NullReferenceException(nameof(pEntidad));

            var direccion = pRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorId(x,pEntidad.Id));

            if (direccion != null)
                return direccion;
            else
                try
                {
                    MailAddress auxiliar = new MailAddress(pEntidad.DireccionDeCorreo);
                    pRepositorio.Agregar(pEntidad);
                    return  pRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorId(x, pEntidad.Id));
                }
                catch (FormatException ex)
                {
                    throw new FormatException("El formato de la direccion de correo no es valida",ex);
                }
        }
    }
}
