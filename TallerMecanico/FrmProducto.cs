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
            var Valores = new List<Valor>();
            Valores.Add(new Valor() { Index = "carro", Value = "1" });
            Valores.Add(new Valor() { Index = "EM", Value = "Empresa" });
            Valores.Add(new Valor() { Index = "XA", Value = "Externo" });
            comboBox1.DataSource = Valores;
            comboBox1.DisplayMember ="Value";
            comboBox1.ValueMember = "Index";

            if (lista == null)
            {

                lista = bLProducto.Listar();
            }
            if (lista.Count > 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dataGridView1.Rows.Add(lista[i].Id, lista[i].Codigo, lista[i].Modelo, lista[i].Nombre,lista[i].Detalles,lista[i].Precio);
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

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                c = new Productos(0, txtCodigo.Text, 1, txtProducto.Text, txtDetalle.Text, txtPrecio.DecimalPlaces);
                n = bLProducto.Insertar(c);
            }
            else
            {
                c.Codigo = txtCodigo.Text;
                //c.Modelo = txtModelo.DecimalPlaces;
                c.Nombre = txtProducto.Text;
                c.Detalles = txtDetalle.Text;
                c.Precio = txtPrecio.DecimalPlaces;
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
        public class Valor
        {
            public string Value { get; set; }
            public string Index { get; set; }
        }
    }
    }

