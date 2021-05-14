using System;
using System.Windows.Forms;
using TallerMecanico.Entidades;
using TallerMecanico.Negocios;

namespace TallerMecanico
{
    public partial class FrmFichaTecnica : Form
    {
        BLCliente blCliente = new BLCliente();
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
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            txtInspectores.Text = UsuarioLogeado.Nombre;
            btnActualizar.Enabled = false;
            btnHistory.Enabled = false;

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
        public int ValidarExistenciCliente(int cliente)
        {
            cl = blCliente.ClienteTraerPorId(Convert.ToInt32(txtCodigo.Text));
            f = bLFichaTecnica.FichaTraerPorId(Convert.ToInt32(txtCodigo.Text));
            if (f.IdConductor != cl.IdConductor)
            {
                MessageBox.Show("Cliente sin existencia", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return 0;
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
            ActivarControlDatos(groupBox6, true);
            textBox1.Enabled = false;
            btnActualizar.Enabled = true;
            btnHistory.Enabled = true;
            textBox1.Text = bLFichaTecnica.ObtenerConsecutivo();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                f = new FichaTecnica(
                0,
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
                txtapto.SelectedItem.ToString(),
                txtEmpresa.Text,
                Convert.ToInt32(txtCodigo.Text),
                txtInspectores.Text,
                UsuarioLogeado.Nombre,
                "",
                DateTime.Now,
                DateTime.UtcNow
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
                f.FtApto = txtapto.Text;
                f.Empresa = txtEmpresa.Text;
                f.IdConductor = Convert.ToInt32(txtCodigo.Text);
                f.FtInspectores = txtInspectores.Text;
                f.FtUsuario = "";
                f.FtUsuarioEdita = UsuarioLogeado.Nombre;
                f.FtFechaReg = DateTime.Now;
                f.FtFechaEdita = DateTime.Now;
                
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

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txtInspectores_TextChanged(object sender, EventArgs e)
        {


            // if (txtapto.Text == "APTO") {

            //    lngRed = RGB(255, 0, 0)
            //}
            //    if (txtapto.Text == "NO APTO") {
            //    lngYellow = RGB(255, 255, 0)
            //}
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            cl = blCliente.ClienteTraerPorId(Convert.ToInt32(txtCodigo.Text));
            f = bLFichaTecnica.FichaTraerPorId(Convert.ToInt32(txtCodigo.Text));
            if (f.IdConductor != cl.IdConductor)
            {
                MessageBox.Show("Cliente sin existencia", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNombre.Text = cl.CliNombres;
            txtApellido.Text = cl.CliApellidos;
            comboCategoria.Text = cl.CliLicenciaTransito;
            txtCodigo.Text = f.IdConductor.ToString();
            txtTarjetaOperacion.Text = f.FtTarjetaOperacion;
            comboEstado.SelectedItem = f.FtEstado;
            txtNumRTMyG.Text = f.FtNumRtmyG.ToString();
            txtNumPolizaSoat.Text = f.FtNumeroPolizaSOAT.ToString();
            txtNumPoliza.Text = f.FtNumeroPolizaRCE.ToString();
            txtLicenciaT.Text = f.FtLicenciaTransito.ToString();
            comboGasesGasolina.SelectedItem = f.FtEmisionGasesGasolina;
            comboGasesDiesel.SelectedItem = f.FtEmisionesGasesDiesel;
            comboLucesP.SelectedItem = f.FtLucesPrincipal;
            comboPFrenado.SelectedItem = f.FtGrupoFreno;
            comboAlineacion.SelectedItem = f.FtAlineacion;
            comboAdherencia.SelectedItem = f.FtAdherencia;
            comboRuido.SelectedItem = f.FtEmisionRuido;
            txtGrupoFrenos.Text = f.FtGrupoFreno;
            txtGrupoSuspension.Text = f.FtGrupoSuspension;
            txtGrupoDir.Text = f.FtGrupoDireccion;
            txtRinesyLlantas.Text = f.FtRinLLanta;
            txtGrupoLuces.Text = f.FtGrupoLuces;
            txtGrupoVidrios.Text = f.FtGrupoVidrio;
            txtGrupoTransmision.Text = f.FtGrupoTransmision;
            txtGrupoMotor.Text = f.FtGrupoMotor;
            txtRevisionEnterior.Text = f.FtRevisionExterior;
            txtRevisionInterior.Text = f.FtRevisionInterior;
            txtapto.Text = f.FtApto;
            txtEmpresa.Text = f.Empresa;
            txtCodigo.Text = f.IdConductor.ToString();
            txtInspectores.Text = f.FtInspectores;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
