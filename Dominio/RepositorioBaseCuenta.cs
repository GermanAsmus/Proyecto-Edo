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
    public class RepositorioBaseCuenta : AgregarCompuesto<Cuenta, Servidor>
    {
        public RepositorioBaseCuenta(IRepositorio<Cuenta> iRepositorio, IGestor pGestor) : base(iRepositorio, pGestor)
        {
            //Constructor
        }

        public override async Task Agregar(Cuenta hijo, Servidor padre)
        {
            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(hijo.Contraseña) || string.IsNullOrEmpty(hijo.CuentaId))
                throw new ArgumentNullException("Atributos");

            //Verifica si la direccion de correo ya está en la base de datos
            RepositorioBaseDireccion ServicioDireccion = (RepositorioBaseDireccion)this.GestorServicio.ObtenerServicio(typeof(DireccionCorreo));

            //valida la direccion de correo
            ValidarDireccionCorreo validarCorreo = (ValidarDireccionCorreo)this.GestorServicio.Validadores[1];

            DireccionCorreo direccion = await validarCorreo.Evaluar(new DireccionCorreo() { DireccionId = hijo.DireccionId });
            if (direccion == null)
                throw new ApplicationException("Direccion de Correo");

            direccion.Cuenta = hijo;
            direccion.CuentaId = hijo.CuentaId;
            hijo.DireccionId = direccion.DireccionId;

            //Obtiene el servidor residente en la base de datos
            IServicio<Servidor> Servicio2 = (IServicio<Servidor>)this.GestorServicio.ObtenerServicio(typeof(Servidor));
            //Servidor servidor = 
            Servidor servidor = await Servicio2.Obtener(x => x.Nombre == padre.Nombre);

            hijo.Servidor = servidor;
            //servidor;
            //servidor
            servidor.Cuenta.Add(hijo);

            hijo.ServidorId = servidor.Nombre;
            //servidor.Nombre;
            //Se actualiza el servidor que contiene a la cuenta
            await Servicio2.Editar(servidor);

        }
    }
}
