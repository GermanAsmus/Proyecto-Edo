﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDependencia
{
    public interface IEncriptador
    {
        bool Encriptar(ref string Cadena);
    }
}