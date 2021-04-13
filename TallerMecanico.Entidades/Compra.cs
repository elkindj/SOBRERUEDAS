using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int IdPersona { get; set; }
        public DateTime Fecha { get; set; }
        public int Descripcion { get; set; }
        public int Subtotal { get; set; }
        public int Iva { get; set; }
        public int Total { get; set; }

        public List<CompraDet> detCompra { get; set; }
    }
}
