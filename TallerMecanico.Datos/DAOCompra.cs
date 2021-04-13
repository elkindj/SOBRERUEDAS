using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TallerMecanico.Datos
{
    public class DAOCompra
    {
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
        public int GrabarCompra(Compra pCompra)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("up_com_reg_compra", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersona", pCompra.IdPersona);
                cmd.Parameters.AddWithValue("@Com_Fecha", pCompra.Fecha);
                cmd.Parameters.AddWithValue("@Com_Observacion", pCompra.Descripcion);
                cmd.Parameters.AddWithValue("@Com_SubTotal", pCompra.Subtotal);
                cmd.Parameters.AddWithValue("@Com_Iva", pCompra.Iva);
                cmd.Parameters.AddWithValue("@Com_Total", pCompra.Total);
                //n = cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    int IdCompra = (int)dr["IdCompra"];
                    dr.Close();
                    pCompra.detCompra.ForEach(c =>
                    {
                        cmd = new SqlCommand("up_reg_det_compra", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCompra", IdCompra);
                        cmd.Parameters.AddWithValue("@IdProducto", c.IdProducto);
                        cmd.Parameters.AddWithValue("@DetCom_Cantidad", c.Cantidad);
                        cmd.Parameters.AddWithValue("@DetCom_ValorUnitario", c.ValorUnitario);
                        cmd.Parameters.AddWithValue("@DetCom_ValorTotal", c.ValorTotal);

                        n = cmd.ExecuteNonQuery();
                    });
                }
            }

            return n;
        }
    }
}
