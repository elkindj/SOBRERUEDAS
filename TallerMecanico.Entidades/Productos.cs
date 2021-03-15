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
        String _codigo;
        int _codP;
        String _modelo;
        String _nombre;
        String _detalles;
        int _precio;
        bool _estado;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public String Codigo {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public int CodP
        {
            get { return _codP; }
            set { _codP = value; }
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
        public Productos(int Id, string Codigo, int CodP, string Modelo, string Nombre,string Detalles,int Precio, bool Estado)
        {
            this._id = Id;
            this._codigo = Codigo;
            this._codP = CodP;
            this._modelo = Modelo;
            this._nombre = Nombre;
            this._detalles = Detalles;
            this._precio = Precio;
            this._estado = Estado;
        }
        //public Productos(int Id, string Codigo, int Modelo, string Nombre, int Precio) : this(Id, Codigo, Modelo, Nombre,"",Precio)
        //{
        //}
        //public Productos(int Id,int Modelo, string Nombre, int Precio) : this(Id, "",Modelo, Nombre, "",Precio)
        //{
        //}
       // public Productos(int Id, int Modelo, int Precio) : this(Id, "", Modelo, "", Precio)
        //{
        //}
        public Productos() : this(0,"", 0,"", "", "",0,false)
        {
        }

    }
}
