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
    public partial class FrmClientes : Form
    {
        List<Cliente> lista = null;
        BLCliente blCliente = new BLCliente();
        Cliente c;
        bool _nuevo = false;
        public FrmClientes()
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
                }
            }
            catch (Exception)
            {
            }
        }
        private void CargarDatos()
        {
            if (lista == null)
            {
                lista = blCliente.Listar();
            }
            if (lista.Count > 0)
            {
                dgvDatos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvDatos.Rows.Add(
                        lista[i].Id,
                        lista[i].IdConductor,
                        lista[i].CliNombres,
                        lista[i].CliApellidos,
                        lista[i].CliLicenciaTransito,
                        lista[i].CliCorreo,
                        lista[i].CliCelular,
                        lista[i].CliDireccion);
                }
            }
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

        private void ActivarButton(bool Estado)
        {
            btnNuevo.Enabled = Estado;
            btnGrabar.Enabled = !Estado;
            btnSalir.Enabled = Estado;
        }
 
       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gbDatos, true);
            btnEditar.Text = "Cancelar";
            btnEditar.Enabled = true;
            ActivarButton(true);
            LimpiarControl(gbDatos);
            txtCodigo.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                c = new Cliente(
                    0,
                    Int32.Parse(txtCodigo.Text), 
                    txtNombre.Text, 
                    txtApellido.Text,
                    comboBox.SelectedItem.ToString(),
                    txtCorreo.Text,
                    txtCelular.Text,
                    txtDireccion.Text,
                    UsuarioLogeado.Nombre, 
                    DateTime.Now,
                    UsuarioLogeado.Nombre,
                    DateTime.Now);
                n = blCliente.Insertar(c);
            }
            else  
            {
                //c.Id = 0;
                c.IdConductor = Int32.Parse(txtCodigo.Text);
                c.CliNombres = txtNombre.Text;
                c.CliApellidos = txtApellido.Text;
                c.CliLicenciaTransito = comboBox.SelectedItem.ToString();
                c.CliCorreo = txtCorreo.Text;
                c.CliCelular = txtCelular.Text;
                c.CliDireccion = txtDireccion.Text;
                //c.CliUsuario = UsuarioLogeado.Nombre;
                //c.CliFechaReg = DateTime.Now;
                //c.CliUsuarioEdita = UsuarioLogeado.Nombre;
                //c.CliFechaEdita = DateTime.Now;
                n = blCliente.Actualizar(c);
            }
            if (n > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                dgvDatos.Enabled = true;
                LimpiarControl(gbDatos);
                btnEditar.Text = "Editar";
                lista = blCliente.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    c = blCliente.ClienteTraerPorId((int)dgvDatos[0, dgvDatos.CurrentRow.Index].Value);
                    txtCodigo.Text = c.IdConductor.ToString();
                    txtNombre.Text = c.CliNombres;
                    txtApellido.Text = c.CliApellidos;
                    comboBox.SelectedItem = c.CliLicenciaTransito;
                    txtCorreo.Text = c.CliCorreo;
                    txtCelular.Text = c.CliCelular;
                    txtDireccion.Text = c.CliDireccion;
                    UsuarioLogeado.Nombre = c.CliUsuario;
                   // DateTime.Now = c.CliFechaReg;
                    UsuarioLogeado.Nombre = c.CliUsuarioEdita;
                    //DateTime.Now = c.CliFechaEdita;
                    ActivarControlDatos(gbDatos, true);
                    ActivarButton(false);
                    btnGrabar.Enabled = true;
                    dgvDatos.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLicencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTarjetaOp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
