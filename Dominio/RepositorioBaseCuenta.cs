﻿using ControlDependencia;
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
    public class RepositorioBaseCuenta : AgregarCompuesto<Cuenta,Servidor>
    {
        public RepositorioBaseCuenta(IRepositorio<Cuenta> iRepositorio,IGestor pGestor) : base(iRepositorio,pGestor)
        {
            //Constructor
        }

        public override void Agregar(Cuenta hijo, Servidor padre)
        {
            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(hijo.Contraseña) || string.IsNullOrEmpty(hijo.CuentaId))
                throw new ArgumentNullException("Atributos");
            //valida la direccion de correo
            ValidarDireccionCorreo validarCorreo = (ValidarDireccionCorreo)this.GestorServicio.Validadores[2];

            DireccionCorreo direccion = validarCorreo.Evaluar(new DireccionCorreo() { DireccionId = hijo.DireccionId });
            if (direccion == null)
                throw new ApplicationException("Direccion de Correo");

            direccion.Cuenta = hijo;
            direccion.CuentaId = hijo.CuentaId;
            hijo.DireccionId = direccion.DireccionId;

            //Obtiene el servidor residente en la base de datos
            IServicio<Servidor> Servicio2 = (IServicio<Servidor>)this.GestorServicio.ObtenerServicio(typeof(Servidor));
            Servidor servidor = Servicio2.Obtener(x => x.Nombre == padre.Nombre);

            direccion.Cuenta = hijo;
            direccion.CuentaId = hijo.CuentaId;
            hijo.DireccionId = direccion.DireccionId;

            hijo.Servidor = servidor;
            servidor.Cuenta.Add(hijo);

            hijo.ServidorId = servidor.Nombre;

            //Se actualiza el servidor que contiene a la cuenta
            Servicio2.Editar(servidor);
        }
    }
}
