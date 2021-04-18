using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Negocios;
using TallerMecanico.Entidades;

namespace TallerMecanico
{
    public partial class FrmVentas : Form
    {
        BLProducto bLProductos = new BLProducto();
        BLCompra bLCompra = new BLCompra();
        public FrmVentas()
        {
            InitializeComponent();
            CargarDatos();
            ActivarControlDatos(false);
        }
        private void CargarDatos()
        {
            txtUsuario.Text = UsuarioLogeado.Nombre;
            cbProducto.DataSource = bLProductos.Listar();
            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "Id";
        }

        public void ActivarControlDatos(bool Estado)
        {
            cbProducto.Enabled = Estado;
            txtCantidad.Enabled = Estado;
            //txtValor.Enabled = Estado;
            //txtDescripcion.Enabled = Estado;
            btnGrabar.Enabled = Estado;
            btnNueva.Enabled = !Estado;
            btnAgregar.Enabled = Estado;
            btnQuitar.Enabled = Estado;
            //btnCancelar.Enabled = Estado;

            cbProducto.SelectedIndex = 1;
            txtCantidad.Text = "0";
           // txtValor.Text = "0";
            //txtDescripcion.Text = "";
            //txtSubTotal.Text = "0";
            //txtIva.Text = "0";
            //txtTotal.Text = "0";


            grdProductos.Rows.Clear();
            grdProductos.AutoGenerateColumns = false;
            grdProductos.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListaProductos frmListaProductos = new FrmListaProductos();
            frmListaProductos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
