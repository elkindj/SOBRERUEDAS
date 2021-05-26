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
    public partial class ReporteFichaTecn : Form
    {
        BLFichaTecnica bLFichaTecnica = new BLFichaTecnica();
        List<FichaTecnica> list= null;
        FichaTecnica fi= new FichaTecnica();
        public ReporteFichaTecn()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            list = bLFichaTecnica.Listar();

            reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.Ficha.rdlc";
            ReportDataSource rds1 = new ReportDataSource("ListarFichaTecnica", list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        private void ReporteFichaTecn_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            list = bLFichaTecnica.Listar();
            reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.Ficha.rdlc";
            ReportDataSource rds1 = new ReportDataSource("ListarFichaTecnica", list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            fi = bLFichaTecnica.FichaTraerPorId(int.Parse(textBox1.Text));
            reportViewer1.LocalReport.ReportEmbeddedResource = "TallerMecanico.Reportes.Ficha.rdlc";
            ReportDataSource rds1 = new ReportDataSource("TraerFichaTecnicaPorId", list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
