using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAOMantenimientoDet
    {
        DatabaseConexion databaseConexion = new DatabaseConexion();
        public MantenimientoDet listarPorId(int pId)
        {
            MantenimientoDet manDet = new MantenimientoDet();

            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("up_dev_mantenimiento_det_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdManDet", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        manDet.IdMantenimientoDet = (int)dr["IdMantenimientoDet"];
                        manDet.IdMantenimiento = (int)dr["IdMantenimiento"];
                        manDet.ManDetEmiGasGas = (string)dr["ManDetEmiGasGas"];
                        manDet.ManDetLucPrin = (string)dr["ManDetLucPrin"];
                        manDet.ManDetPruFre = (string)dr["ManDetPruFre"];
                        manDet.ManDetAli = (string)dr["ManDetAli"];
                        manDet.ManDetEmiGasDis = (string)dr["ManDetEmiGasDis"];
                        manDet.ManDetAdh = (string)dr["ManDetAdh"];
                        manDet.ManDetGruFre = (string)dr["ManDetGruFre"];
                        manDet.ManDetGruSus = (string)dr["ManDetGruSus"];
                        manDet.ManDetGruLuc = (string)dr["ManDetGruLuc"];
                        manDet.ManDetRinLLa = (string)dr["ManDetRinLLa"];
                        manDet.ManDetGruDir = (string)dr["ManDetGruDir"];
                        manDet.ManDetGruVid = (string)dr["ManDetGruVid"];
                        manDet.ManDetGruTran = (string)dr["ManDetGruTran"];
                        manDet.ManDetRevInt = (string)dr["ManDetRevInt"];
                        manDet.ManDetGruMot = (string)dr["ManDetGruMot"];
                        manDet.ManDetRevExt = (string)dr["ManDetRevExt"];
                        manDet.ManDetEstado = (string)dr["ManDetEstado"];
                    }
                }
            }
            return manDet;
        }

        public int Insertar(MantenimientoDet pManDet,int pEstado)
        {
            int n = -1;
            using (SqlConnection con = new
           SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("up_get_mantenimiento_det_id", con);
                cmd.CommandType =
                           CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NuevoEstado", pEstado);
                cmd.Parameters.AddWithValue("@IdMantenimiento", pManDet.IdMantenimiento);
                cmd.Parameters.AddWithValue("@ManDetEmiGasGas", pManDet.ManDetEmiGasGas);
                cmd.Parameters.AddWithValue("@ManDetLucPrin", pManDet.ManDetLucPrin);
                cmd.Parameters.AddWithValue("@ManDetPruFre", pManDet.ManDetPruFre);
                cmd.Parameters.AddWithValue("@ManDetAli", pManDet.ManDetAli);
                cmd.Parameters.AddWithValue("@ManDetEmiGasDis", pManDet.ManDetEmiGasDis);
                cmd.Parameters.AddWithValue("@ManDetAdh", pManDet.ManDetAdh);
                cmd.Parameters.AddWithValue("@ManDetGruFre", pManDet.ManDetGruFre);
                cmd.Parameters.AddWithValue("@ManDetGruSus", pManDet.ManDetGruSus);
                cmd.Parameters.AddWithValue("@ManDetGruLuc", pManDet.ManDetGruLuc);
                cmd.Parameters.AddWithValue("@ManDetRinLLa", pManDet.ManDetRinLLa);
                cmd.Parameters.AddWithValue("@ManDetGruDir", pManDet.ManDetGruDir);
                cmd.Parameters.AddWithValue("@ManDetGruVid", pManDet.ManDetGruVid);
                cmd.Parameters.AddWithValue("@ManDetGruTran", pManDet.ManDetGruTran);
                cmd.Parameters.AddWithValue("@ManDetRevInt", pManDet.ManDetRevInt);
                cmd.Parameters.AddWithValue("@ManDetGruMot", pManDet.ManDetGruMot);
                cmd.Parameters.AddWithValue("@ManDetRevExt", pManDet.ManDetRevExt);
                cmd.Parameters.AddWithValue("@ManDetEstado", pManDet.ManDetEstado);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
