using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;


namespace TallerMecanico.Negocios
{
    public class BLUsuario
    {
        DAOUsuario daoUsuario = new DAOUsuario();

        public List<Usuario> ValidarUsuario(string pUsuario, string pContrsena)
        {
            bool _ingreso = false;
            List<Usuario> usu = new List<Usuario>();

            if (pUsuario != "" || pContrsena != "")
            {
                usu = daoUsuario.ValidarUsuario(pUsuario, pContrsena);
                usu.ForEach(x =>
                {
                    if (x.Usu_Usuario == pUsuario && x.Usu_Contrasena == pContrsena)
                        _ingreso = true;

                });
            }

            return usu;
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usu = new List<Usuario>();
            usu = daoUsuario.ListarUsuarios();

            return usu;
        }

        public bool GrabarUsuario(Usuario pUsuario) {
            //Se realizan la validacoines necesarias
            daoUsuario.GrabarUsuario(pUsuario);
            return true;
        }
    }
}
