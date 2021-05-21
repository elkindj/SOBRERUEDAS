using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;
using TallerMecanico.Datos;

namespace TallerMecanico.Negocios
{
    public class BLCliente
    {
        public List<Cliente> Listar()
        {
            DAOCliente daCliente = new DAOCliente();
            return daCliente.Listar();
        }

        public Cliente ClienteTraerPorId(int Id)
        {
            DAOCliente daCliente = new DAOCliente();
            return daCliente.TraerPorId(Id);
        }

        public int Insertar(Cliente Cliente)
        {
            DAOCliente daCliente = new DAOCliente();
            return daCliente.Insertar(Cliente);
        }

        public int Actualizar(Cliente Cliente)
        {
            DAOCliente daCliente = new DAOCliente();
            return daCliente.Actualizar(Cliente);
        }

        DAOCliente dAOCliente = new DAOCliente();
        public void GrabarCompra(Cliente pCompra)
        {
            dAOCliente.Insertar(pCompra);
        }

        public Cliente ClienteTraerPorDoc(int pDoc)
        {
            DAOCliente daCliente = new DAOCliente();
            return daCliente.TraerPorDoc(pDoc);
        }
    }
}
