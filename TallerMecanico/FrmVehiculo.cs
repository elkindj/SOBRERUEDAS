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
    public partial class FrmVehiculo : Form
    {
        List<Vehiculo> lista = null;
        BLVehiculo blVehiculo = new BLVehiculo();
        BLUsuario blUsuario = new BLUsuario();
        Vehiculo vehiculo;
        bool _nuevo = false;

        public FrmVehiculo()
        {
            InitializeComponent();
            ActivarControlDatos(gbDatos, false);
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
                    if (item.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)item).Enabled = Estado;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void CargarDatos()
        {
            //btnGrabar.Enabled = false;
            //btnEditar.Enabled = false;
            if (lista == null)
            {
                lista = blVehiculo.Listar();
            }
            if (lista.Count > 0)
            {
                dgvDatos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvDatos.Rows.Add(lista[i].Id, lista[i].IdCliente, lista[i].Clase, lista[i].Placa, lista[i].Marca, lista[i].Linea, lista[i].Combustible, lista[i].Modelo);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gbDatos, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string user = LoadUser();
            int n = -1;
            if (_nuevo)
            {
                vehiculo = new Vehiculo(Int32.Parse(txtCodigoVehiculo.Text), Int32.Parse(txtCodigoCliente.Text),
                txtPlaca.Text,
                txtClase.Text,
                txtMarca.Text,
                txtLinea.Text,
                txtCombustible.Text,
                txtModelo.Text,
                user,
                DateTime.UtcNow
                );
                n = blVehiculo.Insertar(vehiculo);
            }
            else
            {
                int codigoVehiculo = Int32.Parse(txtCodigoVehiculo.Text);
                vehiculo.Id = codigoVehiculo;
                int codigoCliente = Int32.Parse(txtCodigoCliente.Text);
                vehiculo.IdCliente = codigoCliente;
                vehiculo.Placa = txtPlaca.Text;
                vehiculo.Clase = txtClase.Text;
                vehiculo.Marca = txtMarca.Text;
                vehiculo.Linea = txtLinea.Text;
                vehiculo.Combustible = txtCombustible.Text;
                vehiculo.Modelo = txtModelo.Text;
                n = blVehiculo.Actualizar(vehiculo);
            }
            if (n > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(gbDatos, true);
                //ActivarButton(true);
                dgvDatos.Enabled = true;
                LimpiarControl(gbDatos);
                //btnEditar.Text = "Editar";
                lista = blVehiculo.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string LoadUser()
        {
            return blUsuario.cacheName["user"] as string;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void ActivarButton(bool Estado)
        {
            //btnNuevo.Enabled = Estado;
            btnGuardar.Enabled = Estado;
            //btnEliminar.Enabled = Estado;
            btnSalir.Enabled = Estado;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _nuevo = false;
            if (btnEditar.Text == "Cancelar")
            {
                LimpiarControl(gbDatos);
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                dgvDatos.Enabled = true;
                btnEditar.Text = "Editar";
            }
            else
            {
                if (dgvDatos.RowCount > 0)
                {
                    vehiculo = blVehiculo.VehiculoTraerPorId((int)dgvDatos[0, dgvDatos.
                    CurrentRow.Index].Value);
                    string codigoVehiculo = vehiculo.Id.ToString();
                    txtCodigoVehiculo.Text = codigoVehiculo;
                    string codigoCliente = vehiculo.IdCliente.ToString();
                    txtCodigoCliente.Text = codigoCliente;
                    txtPlaca.Text = vehiculo.Placa;
                    txtClase.Text = vehiculo.Clase;
                    txtMarca.Text = vehiculo.Marca;
                    txtLinea.Text = vehiculo.Linea;
                    txtCombustible.Text = vehiculo.Combustible;
                    txtModelo.Text = vehiculo.Modelo;
                    ActivarControlDatos(gbDatos, true);
                    //ActivarButton(false);
                    //btnGrabar.Enabled = true;
                    dgvDatos.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LimpiarControl(Control Contenedor)
        {
            foreach (var item in Contenedor.Controls)

            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
