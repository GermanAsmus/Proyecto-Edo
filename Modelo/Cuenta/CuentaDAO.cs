﻿using CapaInterfaces;
using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Linq.Expressions;
using System.Linq;

namespace Modelo
{
    /// <summary>
    /// Entidad abstracta que modela una cuenta de correo.
    /// </summary>
    public abstract class CuentaDAO : EntidadDAO<IMensajeDTO>, ICuentaDAO
    {
        /// <summary>
        /// Mantiene los atributos de la cuenta modelada.
        /// </summary>
        public ICuentaDTO CuentaDTO { get; set; }
        /// <summary>
        /// Atributo responsable de realizar la cuenta cuando se instancie la clase.
        /// </summary>
        protected ICuentaFactory iCuentaFactory;

        /// <summary>
        /// 
        /// Constructor de la clase.
        /// 
        /// La cuenta se realiza instanciado primeramente la clase DTO asociada 
        /// e insertando posteriormente la instancia del ServidorDAO correspondiente.
        /// </summary>
        /// <param name="pCuentaFactory">Clase responsable de definir el ServidorDAO correspondiente</param>
        /// <param name="pDireccion">Direccion del correo</param>
        public CuentaDAO(ICuentaFactory pCuentaFactory, string pDireccion)
        {
            if (string.IsNullOrEmpty(pDireccion))
                throw new ArgumentNullException(nameof(pDireccion));

            this.CuentaDTO = new CuentaDTO() { DireccionCorreo = new DireccionCorreo(pDireccion) };

            this.iCuentaFactory = pCuentaFactory;
            this.RealizarCuenta();
        }

        /// <summary>
        /// Al realizar la cuenta se instancia el servidor.
        /// El servidor se obtiene de la misma direccion de correo (ej: correo@gmail.com --> host = gmail)
        /// </summary>
        protected void RealizarCuenta()
        {
            this.CuentaDTO.Servidor = this.iCuentaFactory.AgregarServidor(DireccionCorreo.ObtenerHost(this.CuentaDTO.DireccionCorreo));
        }

    }
}
