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
    public class DAOUsuario
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

        public List<Usuario> ValidarUsuario(string pUsuario, string pContrasena)
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("up_usu_validar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", pUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", pContrasena);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuario usu = new Usuario((int)dr["IdUsuario"], (string)dr["Usu_Nombre"], (string)dr["Usu_ApellidoPat"], (string)dr["Usu_ApellidoMat"], (int)dr["Usu_IdTipoDocumento"], (int)dr["Usu_Documento"], (string)dr["Usu_Usuario"], (string)dr["Usu_Contrasena"]);
                        lista.Add(usu);
                    }
                }
            }

            return lista;
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("up_usu_listar_usuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuario usu = new Usuario((int)dr["IdUsuario"], (string)dr["Usu_Nombre"], (string)dr["Usu_ApellidoPat"], (string)dr["Usu_ApellidoMat"], (int)dr["Usu_IdTipoDocumento"], (int)dr["Usu_Documento"], (string)dr["Usu_Usuario"]);
                        lista.Add(usu);
                    }
                }
            }

            return lista;

        }
    }
}
