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
        List<Parametros> autocomplete = null;
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
            btnEliminar.Enabled = Estado;
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
                    dataGridView1.Rows.Add(lista[i].Id, lista[i].Codigo, lista[i].Modelo, lista[i].Nombre, lista[i].Detalles, lista[i].Precio);
                }
            }
            if (autocomplete == null)
            {
                autocomplete = bLProducto.Listado();
            }
            if (autocomplete.Count > 0)
            {
                comboBox1.Items.Clear();
                for (int i = 0; i < autocomplete.Count; i++)
                {
                    comboBox1.Items.Add(autocomplete[i].Nombre.ToString());
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
                c = new Productos(0, txtCodigo.Text, comboBox1.SelectedIndex, txtProducto.Text, txtDetalle.Text, Convert.ToInt32(txtPrecio.Text));
                n = bLProducto.Insertar(c);
            }
            else
            {
                c.Codigo = txtCodigo.Text;
                c.Modelo = comboBox1.SelectedIndex;
                c.Nombre = txtProducto.Text;
                c.Detalles = txtDetalle.Text;
                c.Precio = Convert.ToInt32(txtPrecio.Text);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                c = bLProducto.ProductoTraerPorId((int)dataGridView1[0, dataGridView1.
                CurrentRow.Index].Value);
                DialogResult rpta =
                MessageBox.Show("Desea eliminar el registro", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = bLProducto.Eliminar(c.Id);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista = bLProducto.Listar();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    }

