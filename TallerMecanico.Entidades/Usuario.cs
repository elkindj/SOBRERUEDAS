using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Usuario
    {
        int _idUsuario;
        int _idPerfil;
        string _usu_Nombre;
        string _usu_ApellidoPat;
        string _usu_ApellidoMat;
        int _usu_IdTipoDocumento;
        int _usu_Documento;
        string _usu_Usuario;
        string _usu_Contrasena;


        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public int IdPerfil
        {
            get { return _idPerfil; }
            set { _idPerfil = value; }
        }

        public string Usu_Nombre
        {
            get { return _usu_Nombre; }
            set { _usu_Nombre = value; }
        }

        public string Usu_ApellidoPat
        {
            get { return _usu_ApellidoPat; }
            set { _usu_ApellidoPat = value; }
        }

        public string Usu_ApellidoMat
        {
            get { return _usu_ApellidoMat; }
            set { _usu_ApellidoMat = value; }
        }

        public int Usu_IdTipoDoumento
        {
            get { return _usu_IdTipoDocumento; }
            set { _usu_IdTipoDocumento = value; }
        }

        public int Usu_Documento
        {
            get { return _usu_Documento; }
            set { _usu_Documento = value; }
        }

        public string Usu_Usuario
        {
            get { return _usu_Usuario; }
            set { _usu_Usuario = value; }
        }

        public string Usu_Contrasena
        {
            get { return _usu_Contrasena; }
            set { _usu_Contrasena = value; }
        }

        public Usuario(int IdUsuario,int IdPerfil, string Usu_Nombre, string Usu_ApellidoPat, string Usu_ApellidoMat, int Usu_IdTipoDoumento, int Usu_Documento, string Usu_Usuario, string Usu_Contrasena)
        {
            this._idUsuario = IdUsuario;
            this._idPerfil = IdPerfil;
            this._usu_Nombre = Usu_Nombre;
            this._usu_ApellidoPat = Usu_ApellidoPat;
            this._usu_ApellidoMat = Usu_ApellidoMat;
            this._usu_IdTipoDocumento = Usu_IdTipoDoumento;
            this._usu_Documento = Usu_Documento;
            this._usu_Usuario = Usu_Usuario;
            this._usu_Contrasena = Usu_Contrasena;
        }

        public Usuario(int IdUsuario,int IdPerfil, string Usu_Nombre, string Usu_ApellidoPat, string Usu_ApellidoMat, int Usu_IdTipoDoumento, int Usu_Documento, string Usu_Usuario) : this(IdUsuario, IdPerfil, Usu_Nombre, Usu_ApellidoPat, Usu_ApellidoMat, Usu_IdTipoDoumento, Usu_Documento, Usu_Usuario, "")
        {
        }

        //public Categoria(int Id, string Codigo, string Nombre) : this(Id, Codigo, Nombre, "")
        //{
        //}
        //public Categoria(int Id, string Nombre) : this(Id, "", Nombre, "")
        //{
        //}
        //public Categoria() : this(0, "", "", "")
        //{
        //}
    }
}
