using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio
{
    public class RepositorioBaseMensaje : AgregarCompuesto<Completo,Cuenta>
    {
        public RepositorioBaseMensaje(IRepositorio<Completo> pRepositorio,IGestor pGestor) : base(pRepositorio, pGestor)
        {
            //Constructor
        }

        public override async Task Agregar(Completo hijo, Cuenta padre)
        {
            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(hijo.Asunto) || string.IsNullOrEmpty(hijo.MensajeId))
                throw new ApplicationException();

            //verifica cada una de las direcciones de correo
            List<DireccionCorreo> destinatariosValidos = new List<DireccionCorreo>();
            var destinatarios = hijo.Destinatario.GetEnumerator();

            ValidarDireccionCorreo validarCorreo = (ValidarDireccionCorreo)this.GestorServicio.Validadores[2];

            while (destinatarios.MoveNext())
            {
                destinatariosValidos.Add(await validarCorreo.Evaluar(destinatarios.Current));
            }
            hijo.Destinatario = destinatariosValidos;

            IServicio<Cuenta> Servicio2 = (IServicio<Cuenta>)this.GestorServicio.ObtenerServicio(typeof(Cuenta));

            // Cuenta cuenta = 
            await Servicio2.Obtener(x => x.CuentaId == padre.CuentaId).ContinueWith(async (cuenta) =>
            {
                Cuenta cuentaResult = cuenta.Result;
                cuentaResult.Mensajes.Add(hijo);
                //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
                hijo.CuentaId = cuentaResult.CuentaId;
                //Se actualiza la cuenta, que mantiene una colección de mensajes.
                await Servicio2.Editar(cuentaResult);
            });

            //cuenta.Mensajes.Add(hijo);
            ////Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            //hijo.CuentaId = cuenta.CuentaId;
            ////Se actualiza la cuenta, que mantiene una colección de mensajes.
            //Servicio2.Editar(cuenta);
        }
    }
}
