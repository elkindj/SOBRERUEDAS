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
    public partial class FrmFichaTecnica : Form
    {
        BLCliente blCliente = new BLCliente();
        List<Cliente> lista = null;
        Cliente cl;
        BLCliente cliente = new BLCliente();
        FichaTecnica f;
        BLFichaTecnica bLFichaTecnica = new BLFichaTecnica();
        bool _nuevo = false;
        public FrmFichaTecnica()
        {
            InitializeComponent();
            ActivarControlDatos(groupBox1, false);
            ActivarControlDatos(groupBox2, false);
            ActivarControlDatos(groupBox3, false);
            ActivarControlDatos(groupBox4, false);
            ActivarControlDatos(groupBox5, false);
            ActivarControlDatos(groupBox6, false);
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
        public string ValidacionesApto(string apto)
        {
            if (apto == "VENCIDA" || apto == "POR VENCER") {
                return txtapto.Text = "NO APTO";
            }
            if (apto != "CUMPLE CON LA NORMATIVIDAD" || apto != "CUMPLE") {
                return txtapto.Text = "NO APTO";
            }
            return "NO APTO";
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void FrmFichaTecnica_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            txtCodigo.Focus();
            ActivarControlDatos(groupBox1, true);
            ActivarControlDatos(groupBox2, true);
            ActivarControlDatos(groupBox3, true);
            ActivarControlDatos(groupBox4, true);
            ActivarControlDatos(groupBox5, true);
            //ActivarControlDatos(groupBox6, true);
            txtapto.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                f = new FichaTecnica(
                txtTarjetaOperacion.Text,
                comboEstado.SelectedIndex.ToString(),
                Convert.ToInt32(txtNumRTMyG.Text),
                Convert.ToInt32(txtNumPolizaSoat.Text),
                Convert.ToInt32(txtNumPoliza.Text),
                Convert.ToInt32(txtLicenciaT.Text),
                comboGasesGasolina.SelectedItem.ToString(),
                comboGasesDiesel.SelectedItem.ToString(),
                comboLucesP.SelectedItem.ToString(),
                comboPFrenado.SelectedItem.ToString(),
                comboAlineacion.SelectedItem.ToString(),
                comboAdherencia.SelectedItem.ToString(),
                comboRuido.SelectedItem.ToString(),
                txtGrupoFrenos.Text,
                txtGrupoSuspension.Text,
                txtGrupoDir.Text,
                txtRinesyLlantas.Text,
                txtGrupoLuces.Text,
                txtGrupoVidrios.Text,
                txtGrupoTransmision.Text,
                txtGrupoMotor.Text,
                txtRevisionInterior.Text,
                txtRevisionEnterior.Text,
                txtapto.Text= ValidacionesApto(""),
                txtEmpresa.Text,
                Convert.ToInt32(txtCodigo.Text)
                );
                n = bLFichaTecnica.Insertar(f);
            }
            else
            {
                f.FtTarjetaOperacion = txtTarjetaOperacion.Text;
                f.FtEstado = comboEstado.SelectedItem.ToString();
                f.FtNumRtmyG = Convert.ToInt32(txtNumRTMyG.Text);
                f.FtNumeroPolizaSOAT = Convert.ToInt32(txtNumPolizaSoat.Text);
                f.FtNumeroPolizaRCE = Convert.ToInt32(txtNumPoliza.Text);
                f.FtLicenciaTransito = Convert.ToInt32(txtLicenciaT.Text);
                f.FtEmisionGasesGasolina = comboGasesGasolina.SelectedItem.ToString();
                f.FtEmisionesGasesDiesel = comboGasesDiesel.SelectedItem.ToString();
                f.FtLucesPrincipal = comboLucesP.SelectedItem.ToString();
                f.FtGrupoFreno = comboPFrenado.SelectedItem.ToString();
                f.FtAlineacion = comboAlineacion.SelectedItem.ToString();
                f.FtAdherencia = comboAdherencia.SelectedItem.ToString();
                f.FtEmisionRuido = comboRuido.SelectedItem.ToString();
                f.FtGrupoFreno = txtGrupoFrenos.Text;
                f.FtGrupoSuspension = txtGrupoSuspension.Text;
                f.FtGrupoDireccion = txtGrupoDir.Text;
                f.FtRinLLanta = txtRinesyLlantas.Text;
                f.FtGrupoLuces = txtGrupoLuces.Text;
                f.FtGrupoVidrio = txtGrupoVidrios.Text;
                f.FtGrupoTransmision = txtGrupoTransmision.Text;
                f.FtGrupoMotor = txtGrupoMotor.Text;
                f.FtRevisionExterior = txtRevisionEnterior.Text;
                f.FtRevisionInterior = txtRevisionInterior.Text;
                f.FtApto = ValidacionesApto(txtapto.Text);
                f.Empresa = txtEmpresa.Text;
                f.IdConductor = Convert.ToInt32(txtCodigo.Text);

                n = bLFichaTecnica.Actualizar(f);
            }
            if (n > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLicenciaT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ingrese sólo número de licencia", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ingrese sólo número de póliza", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumPolizaSoat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ingrese sólo número de pólizas soat", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumRTMyG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ingrese sólo número rt y g", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ingrese sólo el número de su documento", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                cl = blCliente.ClienteTraerPorId((int)int.Parse(txtCodigo.Text));

                this.txtCodigo.Text = cl.IdConductor.ToString();
                this.txtNombre.Text = cl.CliNombres;
                this.txtApellido.Text = cl.CliApellidos;
                this.comboCategoria.Text = cl.CliLicenciaTransito;
                return;
            }
      
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }
    }
}
