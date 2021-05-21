using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class MantenimientoDet
    {
        public int IdMantenimientoDet { get; set; }
        public int IdMantenimiento { get; set; }
        public string ManDetEmiGasGas { get; set; }
        public string ManDetLucPrin { get; set; }
        public string ManDetPruFre { get; set; }
        public string ManDetAli { get; set; }
        public string ManDetEmiGasDis { get; set; }
        public string ManDetAdh { get; set; }
        public string ManDetGruFre { get; set; }
        public string ManDetGruSus { get; set; }
        public string ManDetGruLuc { get; set; }
        public string ManDetRinLLa { get; set; }
        public string ManDetGruDir { get; set; }
        public string ManDetGruVid { get; set; }
        public string ManDetGruTran { get; set; }
        public string ManDetRevInt { get; set; }
        public string ManDetGruMot { get; set; }
        public string ManDetRevExt { get; set; }
        public string ManDetEstado { get; set; }
    }
}
