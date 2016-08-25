﻿using CapaInterfaces.Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public class BuscarCuenta : CriterioDeBusqueda<ICuenta>
    {
        public new static Func<ICuenta, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<ICuenta, string, bool> BuscarPorNombre = (pEntidad, pNombre) => pEntidad.Nombre == pNombre;
        public static Func<ICuenta, int, bool> BuscarPorDireccion = (pEntidad, pDireccionId) => pEntidad.DireccionId == pDireccionId;
    }
}
