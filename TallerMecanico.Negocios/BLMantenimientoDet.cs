using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocios
{
    public class BLMantenimientoDet
    {
        DAOMantenimientoDet daoManDet = new DAOMantenimientoDet();

        public MantenimientoDet listarPorId(int pId)
        {
            return daoManDet.listarPorId(pId);
        }

        public int Insertar(MantenimientoDet pManDet, int pEstado)
        {
            return daoManDet.Insertar(pManDet, pEstado);
        }
    }
}
