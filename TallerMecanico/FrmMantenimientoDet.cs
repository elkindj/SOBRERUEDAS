using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TallerMecanico.Entidades;
using TallerMecanico.Negocios;

namespace TallerMecanico
{
    public partial class FrmMantenimientoDet : Form
    {
        BLMantenimiento blMan = new BLMantenimiento();
        Mantenimiento ma;
        BLCliente blCliente = new BLCliente();
        Cliente cl;
        BLVehiculo blVehi = new BLVehiculo();
        Vehiculo ve;
        BLMantenimientoDet blManDet = new BLMantenimientoDet();
        MantenimientoDet manDet;

        public FrmMantenimientoDet()
        {
            InitializeComponent();
            iniciarDatos(0);
        }

        private void iniciarDatos(int pIdActual)
        {
            List<Programación> lstPro = new List<Programación>();
            lstPro = blMan.listarPro(1, UsuarioLogeado.Id, 1);
            cbProgramacion.DataSource = lstPro;
            cbProgramacion.DisplayMember = "Progra";
            cbProgramacion.ValueMember = "IdMantenimiento";
            if (pIdActual != 0)
                cbProgramacion.SelectedValue = pIdActual;

            txtInspectores.Text = UsuarioLogeado.Nombre;
        }

        private void cbProgramacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ma = new Mantenimiento();
            ma = blMan.porId(Convert.ToInt32(cbProgramacion.SelectedValue));

            cl = blCliente.ClienteTraerPorId(ma.IdCliente);
            txtDocumento.Text = cl.CliCelular;
            txtNombre.Text = cl.CliNombres;
            txtApellido.Text = cl.CliApellidos;
            txtEmpresa.Text = "";
            txtEstado.Text = "";
            txtCategoria.Text = "";

            ve = blVehi.VehiculoTraerPorId(ma.Idvehiculo);
            txtPlaca.Text = ve.Placa;
            txtLinea.Text = ve.Linea;
            txtClase.Text = ve.Clase;
            txtCombus.Text = ve.Combustible;
            txtMarca.Text = ve.Marca;
            txtModelo.Text = ve.Modelo;

            manDet = blManDet.listarPorId(Convert.ToInt32(cbProgramacion.SelectedValue));
            comboGasesGasolina.SelectedItem = manDet.ManDetEmiGasGas;
            comboLucesP.SelectedItem = manDet.ManDetLucPrin;
            comboPFrenado.SelectedItem = manDet.ManDetPruFre;
            comboAlineacion.SelectedItem = manDet.ManDetAli;
            comboGasesDiesel.SelectedItem = manDet.ManDetEmiGasDis;
            comboAdherencia.SelectedItem = manDet.ManDetAdh;
            txtGrupoFrenos.Text = manDet.ManDetGruFre;
            txtGrupoSuspension.Text = manDet.ManDetGruSus;
            txtGrupoLuces.Text = manDet.ManDetGruLuc;
            txtRinesyLlantas.Text = manDet.ManDetRinLLa;
            txtGrupoDir.Text = manDet.ManDetGruDir;
            txtGrupoVidrios.Text = manDet.ManDetGruVid;
            txtGrupoTransmision.Text = manDet.ManDetGruTran;
            txtRevisionInterior.Text = manDet.ManDetRevInt;
            txtGrupoMotor.Text = manDet.ManDetGruMot;
            txtRevisionEnterior.Text = manDet.ManDetRevExt;
            txtapto.Text = manDet.ManDetEstado;
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
                cl = blCliente.ClienteTraerPorId((int)int.Parse(txtDocumento.Text));

                this.txtDocumento.Text = cl.IdConductor.ToString();
                this.txtNombre.Text = cl.CliNombres;
                this.txtApellido.Text = cl.CliApellidos;
                //this.comboCategoria.Text = cl.CliLicenciaTransito;
                return;
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Msj = validarCampos();
            if (Msj == null)
            {
                guardarDato(2);
            }
        }

        private string validarCampos()
        {
            return null;
        }

        private void guardarDato(int pEstado)
        {
            manDet.IdMantenimiento = Convert.ToInt32(cbProgramacion.SelectedValue);
            manDet.ManDetEmiGasGas = comboGasesGasolina.SelectedItem.ToString();
            manDet.ManDetLucPrin = comboLucesP.SelectedItem.ToString();
            manDet.ManDetPruFre = comboPFrenado.SelectedItem.ToString();
            manDet.ManDetAli = comboAlineacion.SelectedItem.ToString();
            manDet.ManDetEmiGasDis = comboGasesDiesel.SelectedItem.ToString();
            manDet.ManDetAdh = comboAdherencia.SelectedItem.ToString();
            manDet.ManDetGruFre = txtGrupoFrenos.Text;
            manDet.ManDetGruSus = txtGrupoSuspension.Text;
            manDet.ManDetGruLuc = txtGrupoLuces.Text;
            manDet.ManDetRinLLa = txtRinesyLlantas.Text;
            manDet.ManDetGruDir = txtGrupoDir.Text;
            manDet.ManDetGruVid = txtGrupoVidrios.Text;
            manDet.ManDetGruTran = txtGrupoTransmision.Text;
            manDet.ManDetRevInt = txtRevisionInterior.Text;
            manDet.ManDetGruMot = txtGrupoMotor.Text;
            manDet.ManDetRevExt = txtRevisionEnterior.Text;
            manDet.ManDetEstado = txtapto.Text;
            blManDet.Insertar(manDet, pEstado);

            int Idactual = Convert.ToInt32(cbProgramacion.SelectedValue);
            iniciarDatos(Idactual);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string Msj = validarCampos();
            if (Msj == null)
            {
                guardarDato(3);
            }
            iniciarDatos(0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
