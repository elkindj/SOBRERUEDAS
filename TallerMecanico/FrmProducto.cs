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
    public partial class FrmProducto : Form
    {
        List<Productos> lista = null;
        List<Categoria> categorias = null;
        BLCategoria bLCategoria = new BLCategoria();
        BLProducto bLProducto = new BLProducto();
        Productos c;
        bool _nuevo = false;
        public FrmProducto()
        {
            InitializeComponent();
            ActivarControlDatos(groupBox1, false);
            CargarDatos();
        }
        public void ActivarControlDatos(Control Contenedor, bool Estado)
        {
            try
            {
                foreach (var item in Contenedor.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).Enabled = Estado;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void LimpiarControl(Control Contenedor) { foreach (var item in Contenedor.Controls) { if (item.GetType() == typeof(TextBox)) { ((TextBox)item).Clear(); } } }
        private void ActivarButton(bool Estado)
        {
            btnNuevo.Enabled = Estado;
            btnGrabar.Enabled = Estado;
           // btnEliminar.Enabled = Estado;
            btnSalir.Enabled = Estado;
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
                    dataGridView1.Rows.Add(lista[i].Id,lista[i].Codigo, lista[i].NombreP, lista[i].Nombre, lista[i].Modelo, lista[i].Precio, lista[i].Detalles,lista[i].Estado);
                }
            }
            if (categorias == null)
            {
                categorias = bLCategoria.Listar();
            }
            if (categorias.Count > 0)
            {
                txtCodigo.Items.Clear();
                for (int i = 0; i < categorias.Count; i++)
                {
                    txtCodigo.Items.Add(categorias[i].Nombre);
                }
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                c = new Productos(0, txtProducto.Text, txtCodP.Text, txtMarca.Text, txtCodigo.SelectedIndex.ToString(), txtDetalle.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToBoolean(chckEstado.Checked));
                n = bLProducto.Insertar(c);

            }
            else
            {
                c.Nombre = txtProducto.Text;
                c.Codigo = txtCodP.Text;
                c.Modelo = txtMarca.Text;
                c.NombreP = txtCodigo.SelectedIndex.ToString();
                c.Detalles = txtDetalle.Text;
                c.Precio = Convert.ToInt32(txtPrecio.Text);
                c.Estado = Convert.ToBoolean(chckEstado.Checked);
                n = bLProducto.Actualizar(c);
            }
            if (n > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(groupBox1, false);
                ActivarButton(true);
                dataGridView1.Enabled = true;
                LimpiarControl(groupBox1);
                btnEditar.Text = "Editar";
                lista = bLProducto.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(groupBox1, true);
            btnEditar.Text = "Cancelar";
            ActivarButton(true);
            LimpiarControl(groupBox1);
            txtCodigo.Focus();

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _nuevo = false;
            if (btnEditar.Text == "Cancelar")
            {
                LimpiarControl(groupBox1);
                ActivarControlDatos(groupBox1, false);
                ActivarButton(true);
                dataGridView1.Enabled = true;
                btnEditar.Text = "Editar";
            }
            else
            {
                if (dataGridView1.RowCount > 0)
                {
                    c = bLProducto.ProductoTraerPorId((int)dataGridView1[0, dataGridView1.
                    CurrentRow.Index].Value);
                    txtCodigo.Text = c.Codigo;
                    txtDetalle.Text = c.Detalles;
                    int precio = c.Precio;
                    txtPrecio.Text = precio.ToString();
                    txtProducto.Text = c.Nombre;
                    ActivarControlDatos(groupBox1, true);
                    ActivarButton(true);
                    dataGridView1.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }
        }

        private void chckEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodP_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

