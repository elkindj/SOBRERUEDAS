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
        String _nombreP; 
        String _codigo;
        String _modelo;
        String _nombre;
        String _detalles;
        int _precio;
        bool _estado;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public String NombreP
        {
            get { return _nombreP; }
            set { _nombreP = value; }
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
        public Productos(int Id, string NombreP,string Codigo, string Modelo, string Nombre,string Detalles,int Precio, bool Estado)
        {
            this._id = Id;
            this._nombreP = NombreP;
            this._codigo = Codigo;
            this._modelo = Modelo;
            this._nombre = Nombre;
            this._detalles = Detalles;
            this._precio = Precio;
            this._estado = Estado;
        }
        public Productos() : this(0,"","","", "","",0,true)
        {
        }

    }
}
