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
            //1   Administrador Usuarios con privilegios
            //2   Asistente Usuarios de ventas
            //3   Mecanico Usuairos operativo

            if (UsuarioLogeado.IdPerfil == 2)
            {
                btnAdministrar.Visible = false;
                btnCategoria.Visible = false;
                btnProducto.Visible = false;
                //btnProgramarIn.Visible = false;
                btnMantenimientoIn.Visible = false;
            }

            if (UsuarioLogeado.IdPerfil == 3)
            {
                btnAdministrar.Visible = false;
                btnInventario.Visible = false;
                btnCliente.Visible = false;
                btnVehiculo.Visible = false;
                btnReportesIn.Visible = false;
                btnProgramarIn.Visible = false;
            }
        }

        #region evenMenuPrincipal

        private void customizeDesing()
        {
            pnAdministrar.Visible = false;
            pnInventario.Visible = false;
            pnMantenimiento.Visible = false;
            pnReportes.Visible = false;
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

        private void openChidForm(Form pChildForm)
        {
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

        private void btnReportesIn_Click(object sender, EventArgs e)
        {
            showSubMenu(pnReportes);
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
            openChidForm(new FrmVentas());
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

        private void btnProgramarIn_Click(object sender, EventArgs e)
        {
            openChidForm(new FrmMantenimiento());
        }

        private void btnMantenimientoIn_Click(object sender, EventArgs e)
        {
            openChidForm(new FrmMantenimientoDet());
        }

        #endregion

        #region SubMenuReportes

        private void btnRFichaTecnicaIn_Click(object sender, EventArgs e)
        {
            openChidForm(new ReporteFichaTecn());
        }

        private void btnRListaClientesIn_Click(object sender, EventArgs e)
        {
            openChidForm(new FrmReport());
        }

        private void btnRListaComprasIn_Click(object sender, EventArgs e)
        {
           // openChidForm(new FrmMantenimientoDet());
        }

        private void btnRListaVentasIn_Click(object sender, EventArgs e)
        {
            openChidForm(new ReporteFacturaVenta());
           // ReporteFacturaVenta reporteFacturaVenta = new ReporteFacturaVenta();
           // reporteFacturaVenta.ShowDialog();
        }

        private void btnRreciboPagoin_Click(object sender, EventArgs e)
        {
            openChidForm(new ReporteFacturaVenta());
        }

        private void btnRInventarioIn_Click(object sender, EventArgs e)
        {
            openChidForm(new ReporteProducto());
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
