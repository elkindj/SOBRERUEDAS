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
    public class DAOProductos
    {
        DatabaseConexion databaseConexion = new DatabaseConexion();
        public List<Parametros> Listado()
        {
            List<Parametros> lista = new List<Parametros>();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("ListarModelo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Parametros c = new Parametros((int)dr["Id"],(string)dr["Nombre"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        //metodo para traer la lista de todas las categorías de la tabla
        public List<Productos> Listar()
        {
            List<Productos> lista = new List<Productos>();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("ListarProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Productos c = new Productos((int)dr["Id"], (string)dr["Codigo"], (int)dr["Modelo"], (string)dr["Nombre"], (string)dr["Detalles"],(int)dr["Precio"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }
        //metodo para traer una categoría segun su identificación
        public Productos TraerPorId(int Id)
        {
            Productos Productos = new Productos();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                return Productos;
            }
        }
        // metodo para actualizar una Productos puntual 

        public int Actualizar(Productos Productos)
        {
            int n = -1; using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Productos.Id);
                cmd.Parameters.AddWithValue("@Codigo", Productos.Codigo);
                cmd.Parameters.AddWithValue("@Modelo", Productos.Modelo);
                cmd.Parameters.AddWithValue("@Nombre", Productos.Nombre);
                cmd.Parameters.AddWithValue("@Detalles", Productos.Detalles);
                cmd.Parameters.AddWithValue("@Precio", Productos.Precio);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        //metodo para eliminar una categoría puntual 

        public int Eliminar(int Id)
        {
            int n = -1;
            Productos Productos = null;
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                SqlCommand cmd;

                con.Open(); cmd = new SqlCommand("EliminarProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                n = cmd.ExecuteNonQuery(); cmd = new SqlCommand("TraerProductosPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Productos = new Productos(
                    (int)dr["Id"],
                    (string)dr["Codigo"],
                    (int)dr["Modelo"],
                    (string)dr["Nombre"],
                    (string)dr["Detalles"],
                    (int)dr["Precio"]);
                }
            }
            return Productos.Id;
        }
        public int Insertar(Productos Productos)
        {
            int n = -1;
            using (SqlConnection con = new
           SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarProductos", con);
                cmd.CommandType =
               CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Productos.Codigo);
                cmd.Parameters.AddWithValue("@Modelo", Productos.Modelo);
                cmd.Parameters.AddWithValue("@Nombre", Productos.Nombre);
                cmd.Parameters.AddWithValue("@Detalles", Productos.Detalles);
                cmd.Parameters.AddWithValue("@Precio", Productos.Precio);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
