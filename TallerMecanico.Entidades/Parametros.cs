using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Parametros
    {

         int _modelo;
         String _nombre;
            public int Modelo {
            get { return _modelo; }
            set { _modelo = value; }
             }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Parametros(int Modelo, string Nombre) {
            this._modelo = Modelo;
            this._nombre = Nombre;
        }
        public Parametros() : this(0, "") { }

    }
}

