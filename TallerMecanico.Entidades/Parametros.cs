using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Parametros
    {

        int _consecutivoId;
        String _modulo;
        String _prefijo;
        String _consecutivo;
        DateTime _fecha;
        public int ConsecutivoId
        {
            get { return _consecutivoId; }
            set { _consecutivoId = value; }
        }

        public String Modulo
        {
            get { return _modulo; }
            set { _modulo = value; }
        }
        public String Prefijo
        {
            get { return _prefijo; }
            set { _prefijo = value; }
        }
        public String Consecutivo
        {
            get { return _consecutivo; }
            set { _consecutivo = value; }
        }
        //public DateTime Fecha {
        //    get { return _fecha; }
        //    set { _fecha = value; }
        //}
        public Parametros(int ConsecutivoId, string Modulo, string Prefijo, string Consecutivo /*DateTime Fecha*/){
            this._consecutivoId = ConsecutivoId;
            this._modulo = Modulo;
            this._prefijo = Prefijo;
            this._consecutivo= Consecutivo;
            //this._fecha= Fecha;
    }
        public Parametros() : this(0,"","","") { }

    }
}

