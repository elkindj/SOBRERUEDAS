using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAOVentas
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
        public int GrabarVenta(Ventas dVenta)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("up_ven_reg_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersona", dVenta.IdPersona);
                cmd.Parameters.AddWithValue("@Ven_Fecha", dVenta.Fecha);
                cmd.Parameters.AddWithValue("@Ven_Observacion", dVenta.Descripcion);
                cmd.Parameters.AddWithValue("@Ven_SubTotal", dVenta.Subtotal);
                cmd.Parameters.AddWithValue("@Ven_Iva", dVenta.Iva);
                cmd.Parameters.AddWithValue("@Ven_Total", dVenta.Total);
                //n = cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    int IdCompra = (int)dr["IdVenta"];
                    dr.Close();
                    dVenta.detVenta.ForEach(c =>
                    {
                        cmd = new SqlCommand("up_reg_det_venta", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdVenta", IdCompra);
                        cmd.Parameters.AddWithValue("@IdProducto", c.IdProducto);
                        cmd.Parameters.AddWithValue("@DetVen_Cantidad", c.Cantidad);
                        cmd.Parameters.AddWithValue("@DetVen_ValorUnitario", c.ValorUnitario);
                        cmd.Parameters.AddWithValue("@DetVen_ValorTotal", c.ValorTotal);

                        n = cmd.ExecuteNonQuery();
                    });
                }
            }

            return n;
        }
    }
}
