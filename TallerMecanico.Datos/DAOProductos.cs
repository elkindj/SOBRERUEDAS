using System;
using System.Collections.Generic;
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
                con.Open(); SqlCommand cmd = new SqlCommand("up_gen_consecutivo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Parametros c = new Parametros((int)dr["Id"], (string)dr["Nombre"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

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
                        Productos c = new Productos(
                            (int)dr["Id"],
                            (string)dr["CodProducto"],
                            (string)dr["NombreCategoria"],
                            (string)dr["Modelo"],
                            (string)dr["Nombre"],
                            (string)dr["Detalles"],
                            (int)dr["Precio"],
                            (bool)dr["Estado"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }

        public Productos TraerPorId(int Id)
        {
            Productos Productos = new Productos();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerProductosPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Productos = new Productos(
                            (int)dr["Id"],
                            (string)dr["CodProducto"],
                            (string)dr["NombreCategoria"],
                            (string)dr["Modelo"],
                            (string)dr["Nombre"],
                            (string)dr["Detalles"],
                            (int)dr["Precio"],
                            (bool)dr["Estado"]);
                }
            }
            return Productos;
        } 

        public int Actualizar(Productos Productos)
        {
            int n = -1; using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Productos.Id);
                cmd.Parameters.AddWithValue("@CODPRODUCTO",Productos.Codigo);
                cmd.Parameters.AddWithValue("@NOMBRECATEGORIA", Productos.NombreP);
                cmd.Parameters.AddWithValue("@MODELO", Productos.Modelo);
                cmd.Parameters.AddWithValue("@NOMBRE", Productos.Nombre);
                cmd.Parameters.AddWithValue("@DETALLES", Productos.Detalles);
                cmd.Parameters.AddWithValue("@PRECIO", Productos.Precio);
                cmd.Parameters.AddWithValue("@ESTADO", Productos.Estado);
                n = cmd.ExecuteNonQuery();
            }
            return n;
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
                cmd.Parameters.AddWithValue("@CODPRODUCTO", Productos.Codigo);
                cmd.Parameters.AddWithValue("@NOMBRECATEGORIA", Productos.NombreP);
                cmd.Parameters.AddWithValue("@MODELO", Productos.Modelo);
                cmd.Parameters.AddWithValue("@NOMBRE", Productos.Nombre);
                cmd.Parameters.AddWithValue("@DETALLES", Productos.Detalles);
                cmd.Parameters.AddWithValue("@PRECIO", Productos.Precio);
                cmd.Parameters.AddWithValue("@ESTADO", Productos.Estado);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
