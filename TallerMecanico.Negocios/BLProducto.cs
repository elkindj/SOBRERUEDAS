using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocios
{
    public class BLProducto
    {
        public List<Productos> Listar()
		{
			DAOProductos daProducto = new DAOProductos();
			return daProducto.Listar();
		}

		public Productos ProductoTraerPorId(int Id)
		{
			DAOProductos daProducto = new DAOProductos();
			return daProducto.TraerPorId(Id);
		}
		public int Insertar(Productos Productos)
		{
			DAOProductos daProducto = new DAOProductos();
			return daProducto.Insertar(Productos);
		}

		public int Actualizar(Productos Productos)
		{
			DAOProductos daProducto = new DAOProductos();
			return daProducto.Actualizar(Productos);
		}
		public int Eliminar(int id)
		{
			DAOProductos daProducto = new DAOProductos();
			return daProducto.Eliminar(id);
		}
	}
}
