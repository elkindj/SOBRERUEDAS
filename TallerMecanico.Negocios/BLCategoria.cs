using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocios
{
	public class BLCategoria
	{
			public List<Categoria> Listar()
		{
			DAOCategoria daCategoria = new DAOCategoria();
			return daCategoria.Listar();
		}

		public Categoria CategoriaTraerPorId(int Id) {
			DAOCategoria daCategoria = new DAOCategoria();
			return daCategoria.TraerPorId(Id);
		}
		public int Insertar(Categoria Categoria)
		{
			DAOCategoria daCategoria = new DAOCategoria();
			return daCategoria.Insertar(Categoria);
		}

		public int Actualizar(Categoria categoria)
		{
			DAOCategoria daCategoria = new DAOCategoria();
			return daCategoria.Actualizar(categoria);
		}
		public int Eliminar(int id)
		{
			DAOCategoria daCategoria = new DAOCategoria();
			return daCategoria.Eliminar(id);
		}
	}
}
