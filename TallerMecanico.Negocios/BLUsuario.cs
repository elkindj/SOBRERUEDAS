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

        public bool ValidarUsuario(string pUsuario, string pContrsena)
        {
            bool _ingreso = false;

            if (pUsuario != "" || pContrsena != "")
            {
                List<Usuario> usu = new List<Usuario>();
                usu = daoUsuario.ValidarUsuario(pUsuario, pContrsena);
                usu.ForEach(x =>
                {
                    if (x.Usu_Usuario == pUsuario && x.Usu_Contrasena == pContrsena)
                        _ingreso = true;

                });
            }

            return _ingreso;
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usu = new List<Usuario>();
            usu = daoUsuario.ListarUsuarios();

            return usu;
        }
    }
}
