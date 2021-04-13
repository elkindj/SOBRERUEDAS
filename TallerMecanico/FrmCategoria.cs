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
    public partial class FrmCategoria : Form
    {
        List<Categoria> lista = null;
        BLCategoria blCategoria = new BLCategoria();
        BLUsuario bLUsuario = new BLUsuario();
        Categoria c;
        bool _nuevo = false;

        public FrmCategoria()
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
        private void LimpiarControl(Control Contenedor) {
            foreach (var item in Contenedor.Controls) 
            
            { 
            if (item.GetType() == typeof(TextBox)) 
                { 
                    ((TextBox)item).Clear(); 
                }
            if (item.GetType() == typeof(CheckBox))
            {
                ((CheckBox)item).Checked = false;
            }
            } 
        }
        private void ActivarButton(bool Estado)
        {
            btnNuevo.Enabled = Estado;
            btnGrabar.Enabled = Estado;
            //btnEliminar.Enabled = Estado;
            btnSalir.Enabled = Estado;
        }

        private string LoadUser()
        {
            return bLUsuario.cacheName["user"] as string;
        }

        private void CargarDatos()
        {
            btnGrabar.Enabled = false;
            btnEditar.Enabled = false;
            if (lista == null)
            {
                lista = blCategoria.Listar();
            }
            if (lista.Count > 0)
            {
                dgvDatos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvDatos.Rows.Add(lista[i].Id, lista[i].Codigo, lista[i].Nombre, lista[i].Observacion);
                }
            }
        }
        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void gbControl_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gbDatos, true);
            btnEditar.Text = "Cancelar";
            btnEditar.Enabled = true;
            ActivarButton(true);
            LimpiarControl(gbDatos);
            //txtCodigo.Focus();
            // textBox1.Focus();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string user = LoadUser();
            int n = -1;
            if (_nuevo)
            {
                c = new Categoria(0, txtCodigo.Text,
                txtNombre.Text,
                txtObservacion.Text,
                checkBoxEstado.Checked,
                user,
                user,
                DateTime.Now
                );
                n = blCategoria.Insertar(c);
            }
            else
            {
                c.Codigo = txtCodigo.Text;
                c.Nombre = txtNombre.Text;
                c.Observacion = txtObservacion.Text;
                c.Estado = checkBoxEstado.Checked;
                c.UsuarioReg = user;
                c.UsuarioEdita = user;
                //c.FechaEdita = DateTime.Now;
                c.FechaReg = DateTime.Now;
                n = blCategoria.Actualizar(c);
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
                lista = blCategoria.Listar();
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
                    c = blCategoria.CategoriaTraerPorId((int)dgvDatos[0, dgvDatos.
                    CurrentRow.Index].Value);
                    txtCodigo.Text = c.Codigo;
                    txtNombre.Text = c.Nombre;
                    txtObservacion.Text = c.Observacion;
                    ActivarControlDatos(gbDatos, true);
                    ActivarButton(false);
                    btnGrabar.Enabled = true;
                    dgvDatos.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }
        }

        /*private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.RowCount > 0)
            {
                itemIndex = (int)dgvDatos[0, dgvDatos.CurrentRow.Index].Value;
                c = blCategoria.CategoriaTraerPorId(itemIndex);
                DialogResult rpta =
                MessageBox.Show("Desea eliminar el registro", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = blCategoria.Eliminar(c.Id);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista = blCategoria.Listar();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }*/

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
