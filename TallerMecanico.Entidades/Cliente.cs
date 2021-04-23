using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Cliente
    {
    public int Id { get; set; }
    public int IdConductor { get; set; }
    public string CliNombres { get; set; }
    public string CliApellidos { get; set; }
    public string CliCorreo { get; set; }
    public int CliEmpresa { get; set; }
    public string CliCategoriaConductor { get; set; }
    public string CliLicenciaTransito { get; set; }
    public string CliTarjetaOperacion { get; set; }
        public Cliente(
            int Id,
            int IdConductor,
            string CliNombres,
            string CliApellidos,
            string CliCorreo,
            int CliEmpresa,
            string CliCategoriaConductor,
            string CliLicenciaTransito,
            string CliTarjetaOperacion)
        {
            this.Id = Id;
            this.IdConductor = IdConductor;
            this.CliNombres = CliNombres;
            this.CliApellidos = CliApellidos;
            this.CliCorreo = CliCorreo;
            this.CliEmpresa = CliEmpresa;
            this.CliCategoriaConductor = CliCategoriaConductor;
            this.CliLicenciaTransito = CliLicenciaTransito;
            this.CliTarjetaOperacion = CliTarjetaOperacion;
        }

            public Cliente() : this(0, 0, "", "", "", 0, "", "",""){
            }
        }
   }

