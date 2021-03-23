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
            validarMenu(IdPerfil);
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

        private void tSMUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            //frmUsuario.MdiParent = this;
            //frmUsuario.WindowState = FormWindowState.Maximized;
            //frmUsuario.Show();
            frmUsuario.ShowDialog();
        }

        private void tSmSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void validarMenu(int pidPerfil)
        {
            tSMAdministracion.Visible = true;
            tSmInventario.Visible = true;

            if (pidPerfil != 1)
            {
                tSMAdministracion.Visible = false;
            }
        }
    }
}
