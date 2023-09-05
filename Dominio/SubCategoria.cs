﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class SubCategoria
    {
        public int IdSub { get; set; }
        public int idCategoria { get; set; }
        public string Descripcion { get; set; }

        public TimeSpan Duracion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
