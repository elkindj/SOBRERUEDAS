﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
   public class VentaDet
    {
        public int IdDetVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int ValorUnitario { get; set; }
        public int ValorTotal { get; set; }
    }
}