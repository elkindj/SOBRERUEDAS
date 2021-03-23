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
        int _modelo;
        String _nombre;
        String _detalles;
        int _precio;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public String Codigo {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public int Modelo {
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
        public Productos(int Id, string Codigo, int Modelo, string Nombre,string Detalles,int Precio)
        {
            this._id = Id;
            this._codigo = Codigo;
            this._modelo = Modelo;
            this._nombre = Nombre;
            this._detalles = Detalles;
            this._precio = Precio;
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
        public Productos() : this(0, "",0, "", "",0)
        {
        }

        Categoria categoria = new Categoria();

    }
}
