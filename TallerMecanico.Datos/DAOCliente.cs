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
                        (string)dr["Nombres"],
                        (string)dr["Apellidos"],
                        (string)dr["Licencia"],
                        (string)dr["Correo"],
                        (string)dr["Celular"],
                        (string)dr["Direccion"],
                        (string)dr["CliUsuario"],
                        (DateTime)dr["CliFechaReg"],
                        (string)dr["CliUsuarioEdita"],
                        (DateTime)dr["CliFechaEdita"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

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
                        (string)dr["Nombres"],
                        (string)dr["Apellidos"],
                        (string)dr["Licencia"],
                        (string)dr["Correo"],
                        (string)dr["Celular"],
                        (string)dr["Direccion"],
                        (string)dr["CliUsuario"],
                        (DateTime)dr["CliFechaReg"],
                        (string)dr["CliUsuarioEdita"],
                        (DateTime)dr["CliFechaEdita"]);
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
                cmd.Parameters.AddWithValue("@ID", Cliente.Id);
                cmd.Parameters.AddWithValue("@IDCONDUCTOR", Cliente.IdConductor);
                cmd.Parameters.AddWithValue("@NOMBRE", Cliente.CliNombres);
                cmd.Parameters.AddWithValue("@APELLIDO", Cliente.CliApellidos);
                cmd.Parameters.AddWithValue("@LICENCIA", Cliente.CliLicenciaTransito);
                cmd.Parameters.AddWithValue("@CORREO", Cliente.CliCorreo);
                cmd.Parameters.AddWithValue("@DIRECCION", Cliente.CliDireccion);
                cmd.Parameters.AddWithValue("@CELULAR", Cliente.CliCelular);
                cmd.Parameters.AddWithValue("@USUARIO", Cliente.CliUsuarioEdita);
                cmd.Parameters.AddWithValue("FECHAREG", Cliente.CliFechaEdita);
                
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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCONDUCTOR", Cliente.IdConductor);
                cmd.Parameters.AddWithValue("@NOMBRE", Cliente.CliNombres);
                cmd.Parameters.AddWithValue("@APELLIDO", Cliente.CliApellidos);
                cmd.Parameters.AddWithValue("@LICENCIA", Cliente.CliLicenciaTransito);
                cmd.Parameters.AddWithValue("@CORREO", Cliente.CliCorreo);
                cmd.Parameters.AddWithValue("@CELULAR", Cliente.CliCelular);
                cmd.Parameters.AddWithValue("@DIRECCION", Cliente.CliDireccion);
                cmd.Parameters.AddWithValue("@USUARIO", Cliente.CliUsuario);
                cmd.Parameters.AddWithValue("FECHAREG", Cliente.CliFechaReg);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
