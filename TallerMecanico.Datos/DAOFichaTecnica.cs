using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TallerMecanico.Datos
{
    public class DAOFichaTecnica
    {
        DatabaseConexion databaseConexion = new DatabaseConexion();
        string _cadenaConexion;
        public string CadenaConexion
        {
            get
            {
                if (_cadenaConexion == null)
                {
                    _cadenaConexion = ConfigurationManager.
                    ConnectionStrings["Conex"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set { _cadenaConexion = value; }
        }
        public int Insertar(FichaTecnica fichaTecnica)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertaFichaTecnica", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FtTarjetaOperacion", fichaTecnica.FtTarjetaOperacion);
                cmd.Parameters.AddWithValue("@FtEstado", fichaTecnica.FtEstado);
                cmd.Parameters.AddWithValue("@FtNumRtmyG", fichaTecnica.FtNumRtmyG);
                cmd.Parameters.AddWithValue("@FtNumeroPolizaSOAT", fichaTecnica.FtNumeroPolizaSOAT);
                cmd.Parameters.AddWithValue("@FtNumeroPolizaRCE", fichaTecnica.FtNumeroPolizaRCE);
                cmd.Parameters.AddWithValue("@FtLicenciaTransito", fichaTecnica.FtLicenciaTransito);
                cmd.Parameters.AddWithValue("@FtEmisionGasesGasolina", fichaTecnica.FtEmisionGasesGasolina);
                cmd.Parameters.AddWithValue("@FtEmisionesGasesDiesel", fichaTecnica.FtEmisionesGasesDiesel);
                cmd.Parameters.AddWithValue("@FtLucesPrincipal", fichaTecnica.FtLucesPrincipal);
                cmd.Parameters.AddWithValue("@FtPruebaFreno", fichaTecnica.FtPruebaFreno);
                cmd.Parameters.AddWithValue("@FtAlineacion", fichaTecnica.FtAlineacion);
                cmd.Parameters.AddWithValue("@FtAdherencia", fichaTecnica.FtAdherencia);
                cmd.Parameters.AddWithValue("@FtEmisionRuido", fichaTecnica.FtEmisionRuido);
                cmd.Parameters.AddWithValue("@FtGrupoFreno", fichaTecnica.FtGrupoFreno);
                cmd.Parameters.AddWithValue("@FtGrupoSuspension", fichaTecnica.FtGrupoSuspension);
                cmd.Parameters.AddWithValue("@FtGrupoDireccion", fichaTecnica.FtGrupoDireccion);
                cmd.Parameters.AddWithValue("@FtRinLLanta", fichaTecnica.FtRinLLanta);
                cmd.Parameters.AddWithValue("@FtGrupoLuces", fichaTecnica.FtGrupoLuces);
                cmd.Parameters.AddWithValue("@FtGrupoVidrio", fichaTecnica.FtGrupoVidrio);
                cmd.Parameters.AddWithValue("@FtGrupoTransmision", fichaTecnica.FtGrupoTransmision);
                cmd.Parameters.AddWithValue("@FtGrupoMotor", fichaTecnica.FtGrupoMotor);
                cmd.Parameters.AddWithValue("@FtRevisionInterior", fichaTecnica.FtRevisionInterior);
                cmd.Parameters.AddWithValue("@FtRevisionExterior", fichaTecnica.FtRevisionExterior);
                cmd.Parameters.AddWithValue("@FtApto", fichaTecnica.FtApto);
                cmd.Parameters.AddWithValue("@FtEmpresa", fichaTecnica.Empresa);
                cmd.Parameters.AddWithValue("@IdConductor", fichaTecnica.IdConductor);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        public int Actualizar(FichaTecnica fichaTecnica)
        {
            int n = -1; using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizaFichaTecnica", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FtTarjetaOperacion", fichaTecnica.FtTarjetaOperacion);
                cmd.Parameters.AddWithValue("@FtEstado", fichaTecnica.FtEstado);
                cmd.Parameters.AddWithValue("@FtNumRtmyG", fichaTecnica.FtNumRtmyG);
                cmd.Parameters.AddWithValue("@FtNumeroPolizaSOAT", fichaTecnica.FtNumeroPolizaSOAT);
                cmd.Parameters.AddWithValue("@FtNumeroPolizaRCE", fichaTecnica.FtNumeroPolizaRCE);
                cmd.Parameters.AddWithValue("@FtLicenciaTransito", fichaTecnica.FtLicenciaTransito);
                cmd.Parameters.AddWithValue("@FtEmisionGasesGasolina", fichaTecnica.FtEmisionGasesGasolina);
                cmd.Parameters.AddWithValue("@FtEmisionesGasesDiesel", fichaTecnica.FtEmisionesGasesDiesel);
                cmd.Parameters.AddWithValue("@FtLucesPrincipal", fichaTecnica.FtLucesPrincipal);
                cmd.Parameters.AddWithValue("@FtPruebaFreno", fichaTecnica.FtPruebaFreno);
                cmd.Parameters.AddWithValue("@FtAlineacion", fichaTecnica.FtAlineacion);
                cmd.Parameters.AddWithValue("@FtAdherencia", fichaTecnica.FtAdherencia);
                cmd.Parameters.AddWithValue("@FtEmisionRuido", fichaTecnica.FtEmisionRuido);
                cmd.Parameters.AddWithValue("@FtGrupoFreno", fichaTecnica.FtGrupoFreno);
                cmd.Parameters.AddWithValue("@FtGrupoSuspension", fichaTecnica.FtGrupoSuspension);
                cmd.Parameters.AddWithValue("@FtGrupoDireccion", fichaTecnica.FtGrupoDireccion);
                cmd.Parameters.AddWithValue("@FtRinLLanta", fichaTecnica.FtRinLLanta);
                cmd.Parameters.AddWithValue("@FtGrupoLuces", fichaTecnica.FtGrupoLuces);
                cmd.Parameters.AddWithValue("@FtGrupoVidrio", fichaTecnica.FtGrupoVidrio);
                cmd.Parameters.AddWithValue("@FtGrupoTransmision", fichaTecnica.FtGrupoTransmision);
                cmd.Parameters.AddWithValue("@FtGrupoMotor", fichaTecnica.FtGrupoMotor);
                cmd.Parameters.AddWithValue("@FtRevisionInterior", fichaTecnica.FtRevisionInterior);
                cmd.Parameters.AddWithValue("@FtRevisionExterior", fichaTecnica.FtRevisionExterior);
                cmd.Parameters.AddWithValue("@FtApto", fichaTecnica.FtApto);
                cmd.Parameters.AddWithValue("@FtEmpresa", fichaTecnica.Empresa);
                cmd.Parameters.AddWithValue("@IdConductor", fichaTecnica.IdConductor);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

    }
}
