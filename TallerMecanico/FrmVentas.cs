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
            txtValor.Enabled = Estado;
            txtDescripcion.Enabled = Estado;
            btnGrabar.Enabled = Estado;
            btnNueva.Enabled = !Estado;
            btnAgregar.Enabled = Estado;
            btnQuitar.Enabled = Estado;
            btnCancelar.Enabled = Estado;

            cbProducto.SelectedIndex = 1;
            txtCantidad.Text = "0";
            txtValor.Text = "0";
            txtDescripcion.Text = "";
            //txtSubTotal.Text = "0";
            //txtIva.Text = "0";
            //txtTotal.Text = "0";


            grdProductos.Rows.Clear();
            grdProductos.AutoGenerateColumns = false;
            grdProductos.AllowUserToAddRows = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControlDatos(true);
        }

        private void timFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantidad.Text) != 0 && Convert.ToInt32(txtValor.Text) != 0)
            {
                DataGridViewRow fila = new DataGridViewRow();

                bool exist = grdProductos.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["IdDetCompra"].Value) == cbProducto.SelectedValue.ToString());

                if (!exist)
                {
                    fila.CreateCells(grdProductos);
                    label3.Text = cbProducto.SelectedIndex.ToString();
                    fila.Cells[0].Value = 1;
                    fila.Cells[1].Value = cbProducto.Text;
                    fila.Cells[2].Value = txtCantidad.Text;
                    fila.Cells[3].Value = txtValor.Text;
                    int totalValorPro = Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(txtValor.Text);
                    fila.Cells[4].Value = totalValorPro.ToString();

                    grdProductos.Rows.Add(fila);

                    txtCantidad.Text = "0";
                    txtValor.Text = "0";
                }
                else
                {
                }

                //CalcularTotales();
            }
            else
            {
                string Mensaje = "";

                if (Convert.ToInt32(txtCantidad.Text) == 0)
                    Mensaje = "\n - Cantidad";

                if (Convert.ToInt32(txtValor.Text) == 0)
                    Mensaje = Mensaje + "\n - Valor";

                MessageBox.Show("Por favor verificar los siguientes datos" + Mensaje);
            }
        }
    }
}
