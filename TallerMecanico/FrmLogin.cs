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
    public partial class FrmLogin : Form
    {
        BLUsuario blUsuario = new BLUsuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            lblErroPws.Visible = false;

            if (blUsuario.ListarUsuario(txtUsuario.Text, txtContrasena.Text))
            {
                this.Visible = false;
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            else {
                lblErroPws.Text = "Usuario o contraseña incorrecta";
                lblErroPws.Visible = true;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
