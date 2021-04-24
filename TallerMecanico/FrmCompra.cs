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
    public partial class FrmCompra : Form
    {
        BLProducto bLProductos = new BLProducto();
        BLCompra bLCompra = new BLCompra();
        public FrmCompra()
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
            txtSubTotal.Text = "0";
            txtIva.Text = "0";
            txtTotal.Text = "0";


            grdProductos.Rows.Clear();
            grdProductos.AutoGenerateColumns = false;
            grdProductos.AllowUserToAddRows = false;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            ActivarControlDatos(true);
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
                    fila.Cells[0].Value = cbProducto.SelectedValue;
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

                CalcularTotales();
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

        private void CalcularTotales()
        {

            int suma = grdProductos.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells[4].Value));
            double iva = suma * 0.19;
            double total = suma + iva;

            txtSubTotal.Text = suma.ToString();
            txtIva.Text = iva.ToString();
            txtTotal.Text = total.ToString();

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (grdProductos.Rows.Count > 0)
                grdProductos.Rows.Remove(grdProductos.CurrentRow);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.IdCompra = 0;
            compra.IdPersona = UsuarioLogeado.Id;
            compra.Fecha = DateTime.Now;
            compra.Subtotal = Convert.ToInt32(txtSubTotal.Text);
            compra.Iva = Convert.ToInt32(txtIva.Text);
            compra.Total = Convert.ToInt32(txtTotal.Text);
            compra.detCompra = new List<CompraDet>();

            foreach (DataGridViewRow dgvRenglon in grdProductos.Rows)
            {
                CompraDet compraDet = new CompraDet();
                compraDet.IdProducto = Convert.ToInt32(dgvRenglon.Cells[0].Value);
                compraDet.Cantidad = Convert.ToInt32(dgvRenglon.Cells[2].Value);
                compraDet.ValorUnitario = Convert.ToInt32(dgvRenglon.Cells[3].Value);
                compraDet.ValorTotal = Convert.ToInt32(dgvRenglon.Cells[4].Value);

                compra.detCompra.Add(compraDet);
            }

            bLCompra.GrabarCompra(compra);

            ActivarControlDatos(false);
            MessageBox.Show("Compra realizada");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarControlDatos(false);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void ValidarNumero(KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
