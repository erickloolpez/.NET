﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Servicio
    {
        public Servicio()
        {

        }

        public Servicio(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}
