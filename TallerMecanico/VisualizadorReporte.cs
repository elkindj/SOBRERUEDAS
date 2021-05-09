using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class VisualizadorReporte : Form
    {
        public VisualizadorReporte()
        {
            InitializeComponent();
        }

        private void VisualizadorReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetProductos.Productos' Puede moverla o quitarla según sea necesario.
            this.ProductosTableAdapter.Fill(this.DataSetProductos.Productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
