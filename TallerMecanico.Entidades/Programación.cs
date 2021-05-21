using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Programación
    {
        public int IdMantenimiento { get; set; }
        public string Cliente { get; set; }
        public string Placa { get; set; }
        public string Mecanico { get; set; }
        public string Obs { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Progra { get; set; }
    }
}
