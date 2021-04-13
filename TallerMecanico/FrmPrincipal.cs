using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class FrmPrincipal : Form
    {
        public int IdPerfil { get; set; }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuarioActual.Text = UsuarioLogeado.Nombre;
            validarMenu(UsuarioLogeado.Id);
        }

        private void validarMenu(int pidPerfil)
        {
            if (UsuarioLogeado.IdPerfil == 2) {
                tSMAdministracion.Visible = false;
            }

            if (UsuarioLogeado.IdPerfil == 3)
            {
                tSMAdministracion.Visible = false;
                tSmInventario.Visible = false;
            }

        }

        private void tSMUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.WindowState = FormWindowState.Maximized;
            frmUsuario.Show();
        }

        private void tSMCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.WindowState = FormWindowState.Maximized;
            frmCategoria.Show();
        }

        private void tSMProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.MdiParent = this;
            frmProducto.WindowState = FormWindowState.Maximized;
            frmProducto.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompra frmCompra = new FrmCompra();
            frmCompra.MdiParent = this;
            frmCompra.WindowState = FormWindowState.Maximized;
            frmCompra.Show();
        }

        private void tSmSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
