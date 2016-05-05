using ControlDependencia;
using Dominio.Excepciones;
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

        public int Agregar(Mensaje pHijo, Cuenta pPadre)
        {
            if (pHijo == null)
                throw new ArgumentNullException(nameof(pHijo));

            if (pPadre == null)
                throw new ArgumentNullException(nameof(pPadre));

            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(pHijo.Asunto))
                throw new NullReferenceException("El asunto del mensaje no puede ser vacío o nulo");

            //verifica cada una de las direcciones de correo
            List<DireccionCorreo> destinatariosValidos = new List<DireccionCorreo>();
            var destinatarios = pHijo.Destinatario.GetEnumerator();

            IRepositorio<DireccionCorreo> aRepositorioDireccionCorreo = this.GestorServicio.ObtenerRepositorio<DireccionCorreo>();
            IValidar<DireccionCorreo> validarDireccionDeCorreo = new ValidarDireccionCorreo();

            while (destinatarios.MoveNext())
            {
                destinatariosValidos.Add(validarDireccionDeCorreo.Evaluar(destinatarios.Current, aRepositorioDireccionCorreo));
            }
            pHijo.Destinatario = destinatariosValidos;

            IRepositorio<Cuenta> aRepositorioCuenta = this.GestorServicio.ObtenerRepositorio<Cuenta>();
            Cuenta iCuenta = aRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, pPadre.Id));
            if (iCuenta == null)
                throw new NullReferenceException(nameof(iCuenta));

            iCuenta.Mensajes.Add(pHijo);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            pHijo.CuentaId = iCuenta.Id;
            //Se actualiza la cuenta, que mantiene una colección de mensajes.
            return aRepositorioCuenta.Editar(iCuenta);

        }
    }
}
