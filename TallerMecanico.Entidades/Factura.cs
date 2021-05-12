using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Factura
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha { get; set; }
        public int SubTotal { get; set; }
        public int Iva { get; set; }
        public int TotalFactura { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public int ValorUnitario { get; set; }
        public int Total { get; set; }

        public Factura(string Nombres, string Apellidos, string Direccion, DateTime Fecha, int SubTotal, int Iva, int TotalFactura, string NombreProducto, int Cantidad, int ValorUnitario, int Total)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Direccion = Direccion;
            this.Fecha = Fecha;
            this.SubTotal = SubTotal;
            this.Iva = Iva;
            this.TotalFactura = TotalFactura;
            this.NombreProducto = NombreProducto;
            this.Cantidad = Cantidad;
            this.ValorUnitario = ValorUnitario;
            this.Total = Total;
        }

        public Factura() : this("", "", "", DateTime.UtcNow, 0, 0, 0,"",0,0,0 )
        {
        }

    }
}
