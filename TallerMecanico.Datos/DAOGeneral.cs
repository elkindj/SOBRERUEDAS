using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAOGeneral
    {
        DatabaseConexion databaseConexion = new DatabaseConexion();

        public string ObeterConsecutivo(string pModulo)
        {
            string Consecutivo = null;
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("up_gen_consecutivo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Modulo", pModulo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Consecutivo = (string)dr["Consecutivo"];
                }

                return Consecutivo;
            }
        }

        public List<Factura> Listar()
        {
            List<Factura> lista = new List<Factura>();
            using (SqlConnection con = new SqlConnection(databaseConexion.CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("FacturadeVenta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Factura factura = new Factura(
                        (string)dr["Nombres"],
                        (string)dr["Apellidos"],
                        (string)dr["Direccion"],
                        (DateTime)dr["Fecha"],
                        (int)dr["SubTotal"],
                        (int)dr["Iva"],
                        (int)dr["TotalFactura"],
                        (string)dr["NombreProducto"],
                        (int)dr["Cantidad"],
                        (int)dr["ValorUnitario"],
                        (int)dr["Total"]);
                        lista.Add(factura);
                    }
                }
            }
            return lista;
        }
    }
}
