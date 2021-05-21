using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocios
{
    public class BLMantenimiento
    {
        DAOMantenimiento daoMan = new DAOMantenimiento();

        public List<Programación> listarPro(int pTipo,int pIdUsuario,int pEstado) {
            return daoMan.listarPro(pTipo,pIdUsuario,pEstado);
        }

        public Mantenimiento porId(int pId)
        {
            return daoMan.porId(pId);
        }

        public int Insertar(Mantenimiento pMan)
        {
            return daoMan.Insertar(pMan);
        }
    }
}
