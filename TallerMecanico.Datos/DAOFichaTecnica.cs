using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using TallerMecanico.Entidades;

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
            using (SqlConnection con = new
           SqlConnection(databaseConexion.CadenaConexion))
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
                cmd.Parameters.AddWithValue("@FtInspectores", fichaTecnica.FtInspectores);
                cmd.Parameters.AddWithValue("@FtUsuario", fichaTecnica.FtUsuario);
                cmd.Parameters.AddWithValue("@FtUsuarioEdita", fichaTecnica.FtUsuarioEdita);
                cmd.Parameters.AddWithValue("@FtFechaReg", fichaTecnica.FtFechaReg);
                cmd.Parameters.AddWithValue("@FtFechaEdita", fichaTecnica.FtFechaEdita);
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
                cmd.Parameters.AddWithValue("@FtInspectores", fichaTecnica.FtInspectores);
                cmd.Parameters.AddWithValue("@FtUsuario", fichaTecnica.FtUsuario);
                cmd.Parameters.AddWithValue("@FtUsuarioEdita", fichaTecnica.FtUsuarioEdita);
                cmd.Parameters.AddWithValue("@FtFechaReg", fichaTecnica.FtFechaReg);
                cmd.Parameters.AddWithValue("@FtFechaEdita", fichaTecnica.FtFechaEdita);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        public FichaTecnica TraerPorId(int Id)
        {
            FichaTecnica FichaTecnica = new FichaTecnica();
                using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("TraerFichaTecnicaPorId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", Id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null && dr.HasRows)
                    {
                        dr.Read();
                
                    FichaTecnica = new FichaTecnica(
                    (int)dr["IdConsecutivo"],
                    (string)dr["FtTarjetaOperacion"],
                    (string)dr["FtEstado"],
                    (int)dr["FtNumRtmyG"],
                    (int)dr["FtNumeroPolizaSOAT"],
                    (int)dr["FtNumeroPolizaRCE"],
                    (int)dr["FtLicenciaTransito"],
                    (string)dr["FtEmisionGasesGasolina"],
                    (string)dr["FtEmisionesGasesDiesel"],
                    (string)dr["FtLucesPrincipal"],
                    (string)dr["FtPruebaFreno"], 
                    (string)dr["FtAlineacion"],
                    (string)dr["FtAdherencia"],
                    (string)dr["FtEmisionRuido"],
                    (string)dr["FtGrupoFreno"],
                    (string)dr["FtGrupoSuspension"],
                    (string)dr["FtGrupoDireccion"], 
                    (string)dr["FtRinLLanta"], 
                    (string)dr["FtGrupoLuces"], 
                    (string)dr["FtGrupoVidrio"],
                    (string)dr["FtGrupoTransmision"],
                    (string)dr["FtGrupoMotor"],
                    (string)dr["FtRevisionInterior"],
                    (string)dr["FtRevisionExterior"], 
                    (string)dr["FtApto"], 
                    (string)dr["FtEmpresa"],
                    (int)dr["IdConductor"],
                    (string)dr["FtInspectores"], 
                    (string)dr["FtUsuario"],
                    (string)dr["FtUsuarioEdita"], (DateTime)dr["FtFechaReg"], (DateTime)dr["FtFechaEdita"]);
                }
            }
            return FichaTecnica;
        }

    }
}