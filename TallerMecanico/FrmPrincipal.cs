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
        private Form activeForm = null;
        public FrmPrincipal()
        {
            InitializeComponent();
            customizeDesing();
            this.FormBorderStyle = FormBorderStyle.None;
            validarPerfil();
        }

        private void validarPerfil()
        {
            if (UsuarioLogeado.IdPerfil == 3)
                btnAdministrar.Visible = false;
        }

        #region evenMenuPrincipal

        private void customizeDesing()
        {
            pnAdministrar.Visible = false;
            pnInventario.Visible = false;
            pnMantenimiento.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnAdministrar.Visible == true)
                pnAdministrar.Visible = false;
            if (pnInventario.Visible == true)
                pnInventario.Visible = false;
            if (pnMantenimiento.Visible == true)
                pnMantenimiento.Visible = false;
        }

        private void showSubMenu(Panel pSubMenu)
        {
            if (pSubMenu.Visible == false)
            {
                hideSubMenu();
                pSubMenu.Visible = true;
            }
            else
                pSubMenu.Visible = false;
        }

        private void openChidForm(Form pChildForm) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = pChildForm;
            pChildForm.TopLevel = false;
            pChildForm.FormBorderStyle = FormBorderStyle.None;
            pChildForm.Dock = DockStyle.Fill;
            pnFrmPrincipal.Controls.Add(pChildForm);
            pnFrmPrincipal.Tag = pChildForm;
            pChildForm.BringToFront();
            pChildForm.Show();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            showSubMenu(pnAdministrar);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            showSubMenu(pnInventario);
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            showSubMenu(pnMantenimiento);
        }

        #endregion

        #region SubMenuAdministrar

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            openChidForm(new FrmUsuario());
        }

        #endregion

        #region SubMenuInventario

        private void brnCategoria_Click(object sender, EventArgs e)
        {
            openChidForm(new FrmCategoria());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            openChidForm(new FrmProducto());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            openChidForm(new FrmCompra());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //openChidForm(new FrmVentas());
            ReporteFacturaVenta reporteFacturaVenta = new ReporteFacturaVenta();
            reporteFacturaVenta.ShowDialog();
        }

        #endregion

        #region SubMenuMantenimiento

        private void btnCliente_Click(object sender, EventArgs e)
        {
            openChidForm(new FrmClientes());
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
           openChidForm(new FrmVehiculo());
        }

        private void btnMantenimientoIn_Click(object sender, EventArgs e)
        {
            //openChidForm(new FrmVentas());
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
