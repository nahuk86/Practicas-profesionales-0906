﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Empleados
    {
        public  int cod { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }
        public double salario { get; set; }
    }
}
