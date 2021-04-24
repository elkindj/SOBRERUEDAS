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
        List<Usuario> usu = new List<Usuario>();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            lblErroPws.Visible = false;
            usu = blUsuario.ValidarUsuario(txtUsuario.Text, txtContrasena.Text);
            if (usu != null && usu.Count() > 0)
            {
                UsuarioLogeado.Id = usu[0].IdUsuario;
                UsuarioLogeado.Nombre = usu[0].Usu_Nombre;
                UsuarioLogeado.IdPerfil = usu[0].IdPerfil;
                this.Visible = false;
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                lblErroPws.Text = "Usuario o contraseña incorrecta";
                lblErroPws.Visible = true;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnIngresar.PerformClick();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
