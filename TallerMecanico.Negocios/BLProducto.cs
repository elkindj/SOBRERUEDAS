﻿using System;
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

		public List<Parametros> Listado(String Modulo) {
			DAOProductos daProducto = new DAOProductos();
			return daProducto.Listado(Modulo);
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

		public string ObtenerConsecutivo() {
			DAOGeneral daoGeneral = new DAOGeneral();
			string Consecutivo = daoGeneral.ObeterConsecutivo("Producto");
			return Consecutivo;
		}
	}
}
