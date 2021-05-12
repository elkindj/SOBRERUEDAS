using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocios
{
    public class BLGeneral
    {
        public List<Factura> Listar()
        {
            DAOGeneral daoGeneral = new DAOGeneral();
            return daoGeneral.Listar();
        }
    }
}
