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
        public List<Usuario> ValidarUsuario(string pUsuario, string pContrsena)
        {
            List<Usuario> usu = new List<Usuario>();
            string contraseñTem = Encriptar(pContrsena);

            if (pUsuario != "" || pContrsena != "")
            {
                usu = daoUsuario.ValidarUsuario(pUsuario, contraseñTem);
                string name = pUsuario;
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.Priority = System.Runtime.Caching.CacheItemPriority.Default;
                cacheName.Set("user", name, policy);
            }

            return usu;
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usu = new List<Usuario>();
            usu = daoUsuario.ListarUsuarios();

            return usu;
        }

        public bool GrabarUsuario(Usuario pUsuario)
        {

            //TODO:Crear metodo para realizar las validaciones de ingreso
            //Encriptar la contraseña
            pUsuario.Usu_Contrasena = Encriptar(pUsuario.Usu_Contrasena);
            daoUsuario.GrabarUsuario(pUsuario);
            return true;
        }

        private string Encriptar(string pCadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pCadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        private string DesEncriptar(string pCadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(pCadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
