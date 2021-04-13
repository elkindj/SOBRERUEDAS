using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;
using TallerMecanico.Datos;

namespace TallerMecanico.Negocios
{
    public class BLCompra
    {
        DAOCompra daoCompra = new DAOCompra();
        public void GrabarCompra(Compra pCompra)
        {
           daoCompra.GrabarCompra(pCompra);
        }
    }
}
