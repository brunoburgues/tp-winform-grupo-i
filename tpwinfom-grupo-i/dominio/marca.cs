﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        private int Id;
        private string Nombre;

        public Marca(int id, string nombre) {
            Id = id;
            Nombre = nombre;    
        }
    }
}
