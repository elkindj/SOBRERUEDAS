using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAOCategoria
    {
        //metodo para traer la lista de todas las categorías de la tabla

        DatabaseConexion databaseConexion = new DatabaseConexion();
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("ListarCategorias", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Categoria c = new Categoria((int)dr["Id"],
                        (string)dr["Codigo"], 
                        (string)dr["Nombre"], 
                        (string)dr["Observacion"],
                        (bool)dr["Estado"],
                        (string)dr["Usuario"],
                        (string)dr["UsuarioEdita"],
                        (DateTime)dr["FechaReg"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        //metodo para traer una categoría segun su identificación
        public Categoria TraerPorId(int Id)
        {
            Categoria Categoria = new Categoria();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerCategoriaPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Categoria = new Categoria((int)dr["Id"],
                        (string)dr["Codigo"], (string)dr["Nombre"],
                        (string)dr["Observacion"],
                        (bool)dr["Estado"],
                        (string)dr["Usuario"],
                        (string)dr["UsuarioEdita"],
                        (DateTime)dr["FechaReg"]);
                }
            }
            return Categoria;
        }

        // metodo para actualizar una categoria puentual 
        public int Actualizar(Categoria categoria)
        {
            int n = -1; 
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", categoria.Id);
                cmd.Parameters.AddWithValue("@CODIGO", categoria.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Observacion", categoria.Observacion);
                cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        //metodo para eliminar una categoría puntual 
        public int Eliminar(int Id)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }

        public int Insertar(Categoria Categoria)
        {
            int n = -1;
            using (SqlConnection con = new
           SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarCategoria", con);
                cmd.CommandType =
               CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Categoria.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", Categoria.Nombre);
                cmd.Parameters.AddWithValue("@Observacion", Categoria.Observacion);
                cmd.Parameters.AddWithValue("@Estado", Categoria.Estado);
                cmd.Parameters.AddWithValue("@UsuarioReg", Categoria.UsuarioReg);
                cmd.Parameters.AddWithValue("@UsuarioEdita", Categoria.UsuarioEdita);
                cmd.Parameters.AddWithValue("@FechaReg", Categoria.FechaReg);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
