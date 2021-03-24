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
                    dataGridView1.Rows.Add(
                        lista[i].Id,
                        lista[i].Codigo,
                        lista[i].NombreP,
                        lista[i].Modelo,
                        lista[i].Nombre,
                        lista[i].Detalles,
                        lista[i].Precio,
                        lista[i].Estado);
                }
            }
            if (lista == null)
            {
                //c = bLProducto.ProductoTraerPorId((int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                //string valor= "Producto";
                //txtCodP.Text=valor;
                //lista = bLProducto.Listado();
                //txtCodP.Text = bLProducto.Listado();

            }

            if (categorias == null)
            {
                categorias = bLCategoria.Listar();
            }
            if (categorias.Count > 0)
            {
                //comboBox1.Items.Clear();
                //for (int i = 0; i < categorias.Count; i++)
                //{
                //    //comboBox1.Items.Add(categorias[i].Nombre);

                //}
                comboBox1.DataSource = categorias;
                comboBox1.DisplayMember = "Nombre";
                comboBox1.ValueMember = "Id";
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
                c = new Productos(0, txtCodP.Text, Convert.ToInt32(comboBox1.SelectedValue), "", txtMarca.Text, txtProducto.Text, txtDetalle.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToBoolean(chckEstado.Checked), "katherine", DateTime.Now, "katherine", DateTime.Now);
                n = bLProducto.Insertar(c);

            }
            else
            {
                c.Codigo = txtCodP.Text;
                c.NombreP = Convert.ToInt32(comboBox1.SelectedValue);
                c.Modelo = txtMarca.Text;
                c.Nombre = txtProducto.Text;
                c.Detalles = txtDetalle.Text;
                c.Precio = Convert.ToInt32(txtPrecio.Text);
                c.Estado = Convert.ToBoolean(chckEstado.Checked);
                c.UsuarioEdita = "katherine";
                c.UsuarioReg = "katherine";
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
            comboBox1.Focus();

            txtCodP.Enabled = false;
            txtCodP.Text = bLProducto.ObtenerConsecutivo();

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
                    c = bLProducto.ProductoTraerPorId((int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                    txtCodP.Text = c.Codigo;
                    comboBox1.SelectedItem = c.NombreP;
                    txtMarca.Text = c.Modelo;
                    txtProducto.Text = c.Nombre;
                    txtDetalle.Text = c.Detalles;
                    int precio = c.Precio;
                    txtPrecio.Text = precio.ToString();
                    txtPrecio.Text = c.Precio.ToString();
                    chckEstado.Checked = c.Estado;
                    ActivarControlDatos(groupBox1, true);
                    ActivarButton(true);
                    dataGridView1.Enabled = false;
                    btnEditar.Text = "Cancelar";
                    txtCodP.Enabled = false;
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

