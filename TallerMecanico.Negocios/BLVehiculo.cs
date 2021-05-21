using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocios
{
    public class BLVehiculo
    {
        public List<Vehiculo> Listar()
        {
            DAOVehiculo daoVehiculo = new DAOVehiculo();
            return daoVehiculo.Listar();
        }

        public int Insertar(Vehiculo vehiculo)
        {
            DAOVehiculo daoVehiculo = new DAOVehiculo();
            return daoVehiculo.Insertar(vehiculo);
        }

        public Vehiculo VehiculoTraerPorId(int Id)
        {
            DAOVehiculo daoVehiculo = new DAOVehiculo();
            return daoVehiculo.TraerPorId(Id);
        }

        public int Actualizar(Vehiculo vehiculo)
        {
            DAOVehiculo daoVehiculo = new DAOVehiculo();
            return daoVehiculo.Actualizar(vehiculo);
        }

        public Vehiculo VehiculoTraerPorPlaca(int pIdCliente, string pPlaca)
        {
            DAOVehiculo daoVehiculo = new DAOVehiculo();
            return daoVehiculo.TraerPorPlaca(pIdCliente, pPlaca);
        }
    }
}
