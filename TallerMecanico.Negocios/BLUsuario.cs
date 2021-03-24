using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocios
{
    public class BLUsuario
    {
        DAOUsuario daoUsuario = new DAOUsuario();

        public ObjectCache cacheName = System.Runtime.Caching.MemoryCache.Default;
       // public bool ListarUsuario(string pUsuario, string pContrsena);
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
                    string name = pUsuario;
                    CacheItemPolicy policy = new CacheItemPolicy();
                    policy.Priority = System.Runtime.Caching.CacheItemPriority.Default;
                    cacheName.Set("user", name, policy);
                });
            }

            return usu;
        }

        public  List<Usuario> ListarUsuarios()
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
