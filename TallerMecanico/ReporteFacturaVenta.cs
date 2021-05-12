using Microsoft.Reporting.WinForms;
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
    public partial class ReporteFacturaVenta : Form
    {
        BLGeneral bLGeneral = new BLGeneral();

        public List<Factura> list; 
        public ReporteFacturaVenta()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            list = bLGeneral.Listar();

            reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.FacturaVenta.rdlc";
            ReportDataSource rds1 = new ReportDataSource("Factura", list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        private void ReporteFacturaVenta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
