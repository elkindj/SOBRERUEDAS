using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TallerMecanico.Entidades;
using TallerMecanico.Negocios;

namespace TallerMecanico
{
    public partial class FrmReport : Form
    {
        List<Cliente> lista = null;
        //List<Entidades.Productos> lista2 = null;
        BLCliente bLCliente = new BLCliente();

        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            CargarReporte();

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void CargarReporte()
        {
            lista = bLCliente.Listar();

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.Clientes.rdlc";
            ReportDataSource rds1 = new ReportDataSource("TraerClientePorId", lista);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lista = bLCliente.ClienteTraerPorId(int.Parse(txtID.Text));

            ///Mostrar datos en el reporte
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.Clientes.rdlc";
            ReportDataSource rds1 = new ReportDataSource("TraerClientePorId", lista);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lista = bLCliente.Listar();

            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.Clientes.rdlc";
            //ReportDataSource rds1 = new ReportDataSource("ListarCli", lista);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(rds1);
            //this.reportViewer1.RefreshReport();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lista = bLCliente.Listar();

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.Clientes.rdlc";
            ReportDataSource rds1 = new ReportDataSource("ListaCliente", lista);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
