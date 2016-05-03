using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using Utilidades;

namespace Dominio
{
    public class RepositorioMensaje : RepositorioAbstracto<Mensaje>, IEstrategiaAgregarComplejo<Mensaje, Cuenta>
    {
        public RepositorioMensaje(IRepositorio<Mensaje> pRepositorio, IGestorRespositorios pGestor) : base(pRepositorio, pGestor)
        {
            //Constructor
        }

        public int Agregar(Mensaje hijo, Cuenta padre)
        {
            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(hijo.Asunto))
                throw new ApplicationException();

            //verifica cada una de las direcciones de correo
            List<DireccionCorreo> destinatariosValidos = new List<DireccionCorreo>();
            var destinatarios = hijo.Destinatario.GetEnumerator();

            IRepositorio<DireccionCorreo> aRepositorioDireccionCorreo = this.GestorServicio.ObtenerRepositorio<DireccionCorreo>();
            IValidar<DireccionCorreo> validarDireccionDeCorreo = new ValidarDireccionCorreo();

            while (destinatarios.MoveNext())
            {
                destinatariosValidos.Add(validarDireccionDeCorreo.Evaluar(destinatarios.Current, aRepositorioDireccionCorreo));
            }
            hijo.Destinatario = destinatariosValidos;

            IRepositorio<Cuenta> aRepositorioCuenta = this.GestorServicio.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = aRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, padre.Id));
            if (unaCuenta == null)
                throw new Exception("No existe la cuenta en la bd");

            unaCuenta.Mensajes.Add(hijo);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            hijo.CuentaId = unaCuenta.Id;
            //Se actualiza la cuenta, que mantiene una colección de mensajes.
            return aRepositorioCuenta.Editar(unaCuenta);

        }
    }
}
