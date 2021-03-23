using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Productos
    {
        int _id;
        int _nombreP; 
        String _nombreCategoria;
        String _codigo;
        String _modelo;
        String _nombre;
        String _detalles;
        int _precio;
        bool _estado;
        String _usuarioReg;
        DateTime _fechaReg;
        String _usuarioEdita;
        DateTime _fechaEdita;

      
        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public int NombreP
        {
            get { return _nombreP; }
            set { _nombreP = value; }
        }
        public String NombreCategoria
        {
            get { return _nombreCategoria; }
            set { _nombreCategoria = value; }
        }
        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public String Modelo {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public String Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public String Detalles {
            get { return _detalles; }
            set { _detalles = value; }
        }
        public int Precio {
            get { return _precio; }
            set { _precio = value; }
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
        public Productos(int Id, string Codigo, int NombreP,string NombreCategoria, string Modelo, string Nombre,string Detalles,int Precio, bool Estado,
            string UsuarioReg, DateTime FechaReg, string UsuarioEdita,DateTime FechaEdita)
        {
            this._id = Id;
            this._codigo = Codigo;
            this._nombreP = NombreP;
            this._nombreCategoria = NombreCategoria;
            this._modelo = Modelo;
            this._nombre = Nombre;
            this._detalles = Detalles;
            this._precio = Precio;
            this._estado = Estado;
            this._usuarioReg = UsuarioReg;
            this._fechaReg = FechaReg;
            this._usuarioEdita = UsuarioEdita;
            this._fechaEdita = FechaEdita;
        }
        public Productos() : this(0,"",0,"","", "","",0,true,"", DateTime.Now, "",DateTime.Now)
        {
        }

        Categoria categoria = new Categoria();

    }
}
