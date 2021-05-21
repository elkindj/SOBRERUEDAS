using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAOMantenimiento
    {
        DatabaseConexion databaseConexion = new DatabaseConexion();

        public List<Programación> listarPro(int pTipo, int pIdUsuario, int pEstado)
        {
            List<Programación> lstMan = new List<Programación>();

            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("up_dev_programacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tipo", pTipo);
                cmd.Parameters.AddWithValue("@IdUsuario", pIdUsuario);
                cmd.Parameters.AddWithValue("@Estado", pEstado);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Programación man = new Programación();
                        man.IdMantenimiento = (int)dr["IdMantenimiento"];
                        man.Cliente = (string)dr["Cliente"];
                        man.Placa = (string)dr["Placa"];
                        man.Mecanico = (string)dr["Mecanico"];
                        man.Obs = (string)dr["Observaciones"];
                        man.Fecha = (DateTime)dr["Fecha"];
                        man.Estado = (string)dr["Estado"];
                        man.Progra = (string)dr["Programacion"];
                        lstMan.Add(man);
                    }
                }
            }
            return lstMan;
        }

        public Mantenimiento porId(int pId) {

            Mantenimiento man = new Mantenimiento();

            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("up_dev_programacion_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        man.IdCliente = (int)dr["IdCliente"];
                        man.Idvehiculo = (int)dr["IdVehiculo"];
                        man.IdUsuario = (int)dr["IdUsuarioMec"];
                        man.Fecha = (DateTime)dr["Fecha"];
                        man.Obs = (string)dr["Observaciones"];
                        man.Estado = (int)dr["Estado"];
                    }
                }
            }
            return man;
        }

        public int Insertar(Mantenimiento pMan)
        {
            int n = -1;
            using (SqlConnection con = new
           SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("up_reg_programacion", con);
                cmd.CommandType =
                           CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", pMan.IdCliente);
                cmd.Parameters.AddWithValue("@Idvehiculo", pMan.Idvehiculo);
                cmd.Parameters.AddWithValue("@IdUsuario", pMan.IdUsuario);
                cmd.Parameters.AddWithValue("@Fecha", pMan.Fecha);
                cmd.Parameters.AddWithValue("@Obs", pMan.Obs);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
