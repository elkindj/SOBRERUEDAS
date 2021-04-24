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
     public class DAOVehiculo
    {
        DatabaseConexion databaseConexion = new DatabaseConexion();
        public List<Vehiculo> Listar()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("ListarVehiculos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Vehiculo vehiculo = new Vehiculo((int)dr["Id"],
                        (int)dr["IdCliente"],
                        (string)dr["Placa"],
                        (string)dr["Clase"],
                        (string)dr["Marca"],
                        (string)dr["Linea"],
                        (string)dr["Combustible"],
                        (string)dr["Modelo"]);
                        lista.Add(vehiculo);
                    }
                }
            }
            return lista;
        }

        public int Insertar(Vehiculo vehiculo)
        {
            int n = -1;
            using (SqlConnection con = new
           SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarVehiculo", con);
                cmd.CommandType =
               CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", vehiculo.Id);
                cmd.Parameters.AddWithValue("@Cliente", vehiculo.IdCliente);
                cmd.Parameters.AddWithValue("@Placa", vehiculo.Placa);
                cmd.Parameters.AddWithValue("@Clase", vehiculo.Clase);
                cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@Linea", vehiculo.Linea);
                cmd.Parameters.AddWithValue("@Combustible", vehiculo.Combustible);
                cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public Vehiculo TraerPorId(int Id)
        {
            Vehiculo vehiculo = new Vehiculo();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerVehiculoPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                     vehiculo = new Vehiculo((int)dr["Id"],
                        (int)dr["IdCliente"],
                        (string)dr["Placa"],
                        (string)dr["Clase"],
                        (string)dr["Marca"],
                        (string)dr["Linea"],
                        (string)dr["Combustible"],
                        (string)dr["Modelo"]);
                }
            }
            return vehiculo;
        }

        public int Actualizar(Vehiculo vehiculo)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarVehiculo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", vehiculo.Id);
                cmd.Parameters.AddWithValue("@Codigo", vehiculo.Id);
                cmd.Parameters.AddWithValue("@Cliente", vehiculo.IdCliente);
                cmd.Parameters.AddWithValue("@Placa", vehiculo.Placa);
                cmd.Parameters.AddWithValue("@Clase", vehiculo.Clase);
                cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@Linea", vehiculo.Linea);
                cmd.Parameters.AddWithValue("@Combustible", vehiculo.Combustible);
                cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
