using ControlDependencia;
using ControlDependencia.Dominio;
using Modelo;
using System;
using Utilidades;
using Utilidades.CriteriosDeBusqueda;

namespace Dominio
{
    public class RepositorioCuenta : RepositorioAbstracto<Cuenta>,IEstrategiaAgregarComplejo<Cuenta, Servidor>
    {
        public RepositorioCuenta(IRepositorio<Cuenta> iRepositorio, IGestorRespositorios pGestor) : base(iRepositorio, pGestor)
        {

        }
        //Se previene que pHijo y pPadre no sean nulos

        public int Agregar(Cuenta pHijo, Servidor pPadre)
        {
            if (pHijo == null)
                throw new ArgumentNullException(nameof(pHijo));

            if (pPadre == null)
                throw new ArgumentNullException(nameof(pPadre));

            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(pHijo.Contraseña) || string.IsNullOrEmpty(pHijo.Nombre))
                throw new NullReferenceException("Los atributos contraseña, nombre, no pueden ser nulos o vacíos");

            //Verifica si la direccion de correo ya está en la base de datos
            IRepositorio<DireccionCorreo> aRepositorioDireccion = this.GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
                        
            DireccionCorreo iDireccion = new Utilidades.Validacion.ValidarDireccionCorreo().Evaluar(pHijo.DireccionCorreo, aRepositorioDireccion);
            if (iDireccion == null)
                throw new NullReferenceException(nameof(iDireccion));

            iDireccion.Cuenta = pHijo;
            iDireccion.CuentaId = pHijo.Id;
            pHijo.DireccionId = iDireccion.Id;

            //Obtiene el servidor residente en la base de datos
            IRepositorio<Servidor> aRepositorioServidor = this.GestorRepositorios.ObtenerRepositorio<Servidor>();
            Servidor unServidor = aRepositorioServidor.Obtener(x => BuscarServidor.BuscarPorNombre(x,pPadre.Nombre));

            pHijo.Servidor = unServidor;

            unServidor.Cuenta.Add(pHijo);

            pHijo.ServidorId = unServidor.Id;
            return aRepositorioServidor.Editar(unServidor);
        }
    }
}
