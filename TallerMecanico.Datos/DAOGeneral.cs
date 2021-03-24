using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
    }
}
