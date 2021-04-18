using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;
using TallerMecanico.Datos;

namespace TallerMecanico.Negocios
{
    public class BLVentas
    {
        DAOVentas daoVenta = new DAOVentas();
        public void GrabarVenta(Ventas pVenta)
        {
            daoVenta.GrabarVenta(pVenta);
        }
    }
}