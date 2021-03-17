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
        public Categoria(int Id, string Codigo, string Nombre, string Observacion,bool Estado)
        {
            this._id = Id;
            this._codigo = Codigo;
            this._nombre = Nombre;
            this._observacion = Observacion;
            this._estado = Estado;
        }
        public Categoria(int Id, string Codigo, string Nombre, bool Estado) : this(Id, Codigo, Nombre, "", Estado)
        {
        }
        public Categoria(int Id, string Nombre,bool Estado) : this(Id, "", Nombre, "", Estado)
        {
        }
        public Categoria() : this(0, "", "", "",true)
        {
        }
    }
}
