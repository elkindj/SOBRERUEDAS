using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocios
{
	public class BLFichaTecnica
	{

		public Productos ProductoTraerPorId(int Id)
		{
			DAOProductos daProducto = new DAOProductos();
			return daProducto.TraerPorId(Id);
		}

		public int Insertar(FichaTecnica fichaTecnica)
		{
			DAOFichaTecnica daFichaTecnica = new DAOFichaTecnica();
			return daFichaTecnica.Insertar(fichaTecnica);
		}

		public int Actualizar(FichaTecnica fichaTecnica)
		{
			DAOFichaTecnica dAOFichaTecnica = new DAOFichaTecnica();
			return dAOFichaTecnica.Actualizar(fichaTecnica);
		}
		public string ObtenerConsecutivo()
		{
			DAOGeneral daoGeneral = new DAOGeneral();
			string Consecutivo = daoGeneral.ObeterConsecutivo("Producto");
			return Consecutivo;
		}
	}
}
