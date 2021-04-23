using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAOCliente
    {

        DatabaseConexion databaseConexion = new DatabaseConexion();
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("ListarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente c = new Cliente(
                        (int)dr["Id"],
                        (int)dr["IdConductor"],
                        (String)dr["Nombres"],
                        (String)dr["Apellidos"],
                        (String)dr["Correo"],
                        (int)dr["Empresa"],
                        (String)dr["CategoriaConductor"],
                        (String)dr["LicenciaTran"],
                        (String)dr["TarjetaOp"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        //metodo para traer una categoría segun su identificación
        public Cliente TraerPorId(int Id)
        {
            Cliente Cliente = new Cliente();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerClientePorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Cliente = new Cliente(
                       (int)dr["Id"],
                        (int)dr["IdConductor"],
                        (String)dr["Nombres"],
                        (String)dr["Apellidos"],
                        (String)dr["Correo"],
                        (int)dr["Empresa"],
                        (String)dr["ClienteConductor"],
                        (String)dr["LicenciaTran"],
                        (String)dr["TarjetaOp"]);
                }
            }
            return Cliente;
        }

        public int Actualizar(Cliente Cliente)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Cliente.Id);
                cmd.Parameters.AddWithValue("@IDCONDUCTOR", Cliente.IdConductor);
                cmd.Parameters.AddWithValue("@NOMBRE", Cliente.CliNombres);
                cmd.Parameters.AddWithValue("@APELLIDO", Cliente.CliApellidos);
                cmd.Parameters.AddWithValue("@EMPRESA", Cliente.CliEmpresa);
                cmd.Parameters.AddWithValue("@CATEGORIA", Cliente.CliCategoriaConductor);
                cmd.Parameters.AddWithValue("@LICENCIA", Cliente.CliLicenciaTransito);
                cmd.Parameters.AddWithValue("@TARJETAOP", Cliente.CliTarjetaOperacion);
                cmd.Parameters.AddWithValue("@CORREO", Cliente.CliCorreo);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int Insertar(Cliente Cliente)
        {
            int n = -1;
            using (SqlConnection con = new
           SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarCliente", con);
                cmd.CommandType =
                CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDCONDUCTOR", Cliente.IdConductor);
                cmd.Parameters.AddWithValue("@NOMBRE", Cliente.CliNombres);
                cmd.Parameters.AddWithValue("@APELLIDO", Cliente.CliApellidos);
                cmd.Parameters.AddWithValue("@CORREO", Cliente.CliCorreo);
                cmd.Parameters.AddWithValue("@EMPRESA", Cliente.CliEmpresa);
                cmd.Parameters.AddWithValue("@CATEGORIA", Cliente.CliCategoriaConductor);
                cmd.Parameters.AddWithValue("@LICENCIA", Cliente.CliLicenciaTransito);
                cmd.Parameters.AddWithValue("@TARJETAOP", Cliente.CliTarjetaOperacion);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
