using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Entidades;
using TallerMecanico.Negocios;

namespace TallerMecanico
{
    public partial class FrmListaProductos : Form
    {
        List<Productos> lista = null;
        BLProducto bLProducto = new BLProducto();

        public FrmListaProductos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (lista == null)
            {
                lista = bLProducto.Listar();
            }
            if (lista.Count > 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dataGridView1.Rows.Add(
                        lista[i].Id,
                        lista[i].Codigo,
                        lista[i].NombreP,
                        lista[i].Precio);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
