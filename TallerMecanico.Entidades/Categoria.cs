using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Categoria
    {
        int _id;
        string _codigo;
        string _nombre;
        string _observacion;
        bool _estado;
        String _usuarioReg;
        DateTime _fechaReg;
        String _usuarioEdita;
        DateTime _fechaEdita;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public String UsuarioReg
        {
            get { return _usuarioReg; }
            set { _usuarioReg = value; }
        }
        public DateTime FechaReg
        {
            get { return _fechaReg; }
            set { _fechaReg = value; }
        }
        public String UsuarioEdita
        {
            get { return _usuarioEdita; }
            set { _usuarioEdita = value; }
        }
        public DateTime FechaEdita
        {
            get { return _fechaEdita; }
            set { _fechaEdita = value; }
        }
        public Categoria(int Id, string Codigo, string Nombre, string Observacion,bool Estado, string UsuarioReg, string UsuarioEdita,DateTime FechaReg)
        {
            this._id = Id;
            this._codigo = Codigo;
            this._nombre = Nombre;
            this._observacion = Observacion;
            this._estado = Estado;
            this._usuarioReg = UsuarioReg;
            this._usuarioEdita = UsuarioEdita;
            this._fechaReg = FechaReg;
        }

        public Categoria() : this(0, "", "", "",true,"","",DateTime.UtcNow)
        {
        }
    }
}
