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
    public partial class FrmUsuario : Form
    {
        BLUsuario bLUsuario = new BLUsuario();
        public FrmUsuario()
        {
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            var Valores = new List<Valor>();
            Valores.Add(new Valor() { Index = "1", Value = "Tarjeta de identidad" });
            Valores.Add(new Valor() { Index = "2", Value = "Cedula de Ciudadania" });
            Valores.Add(new Valor() { Index = "3", Value = "Pasaporte" });
            cbTipDocumento.DataSource = Valores;
            cbTipDocumento.DisplayMember = "Value";
            cbTipDocumento.ValueMember = "Index";

            Valores = new List<Valor>();
            Valores.Add(new Valor() { Index = "1", Value = "Administrador" });
            Valores.Add(new Valor() { Index = "2", Value = "Asistente" });
            Valores.Add(new Valor() { Index = "3", Value = "Mecanico" });
            cbPerfil.DataSource = Valores;
            cbPerfil.DisplayMember = "Value";
            cbPerfil.ValueMember = "Index";

            Valores = new List<Valor>();
            Valores.Add(new Valor() { Index = "1", Value = "Activo" });
            Valores.Add(new Valor() { Index = "0", Value = "Inactivo" });
            cbEstado.DataSource = Valores;
            cbEstado.DisplayMember = "Value";
            cbEstado.ValueMember = "Index";

            gridUsuarios.AutoGenerateColumns = false;
            gridUsuarios.DataSource = bLUsuario.ListarUsuarios();

        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Usuario nUsuario = new Usuario(
                0, Convert.ToInt32(cbPerfil.SelectedValue), txtNombre.Text,txtApellidoPa.Text,txtPallidoMa.Text
                , Convert.ToInt32(cbTipDocumento.SelectedValue), Convert.ToInt32(txtNumDocumento.Text), txtUsuario.Text);

            bLUsuario.GrabarUsuario(nUsuario);

            MessageBox.Show("Usuario creado");
            CargarDatos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Valor
        {
            public string Value { get; set; }
            public string Index { get; set; }
        }
    }
}
