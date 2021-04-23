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
    public String CliNombres { get; set; }
    public String CliApellidos { get; set; }
    public String CliCorreo { get; set; }
    public int CliEmpresa { get; set; }
    public String CliCategoriaConductor { get; set; }
    public String CliLicenciaTransito { get; set; }
    public String CliTarjetaOperacion { get; set; }
        public Cliente(int Id,
            int IdConductor,
            String CliNombres,
            String CliApellidos,
            String CliCorreo,
            int CliEmpresa,
            String CliCategoriaConductor,
            String CliLicenciaTransito,
            String CliTarjetaOperacion)
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

