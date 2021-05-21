using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Mantenimiento
    {
        public int IdCliente { get; set; }
        public int Idvehiculo { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Obs { get; set; }
        public int Estado { get; set; }
    }
}
