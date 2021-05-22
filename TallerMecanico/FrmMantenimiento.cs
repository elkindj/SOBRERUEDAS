using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TallerMecanico.Entidades;
using TallerMecanico.Negocios;

namespace TallerMecanico
{
    public partial class FrmMantenimiento : Form
    {
        BLCliente blCliente = new BLCliente();
        Cliente cl = new Cliente();
        BLVehiculo bLVehiculo = new BLVehiculo();
        Vehiculo ve = new Vehiculo();
        BLUsuario bLUsuario = new BLUsuario();
        Usuario usu;
        BLMantenimiento blMan = new BLMantenimiento();
        Mantenimiento man;
        int IdUsuarioMec;

        public FrmMantenimiento()
        {
            InitializeComponent();
            dgvProgramacion.AutoGenerateColumns = false;
            listarPro(0);
        }

        private void listarPro(int pIdUsuario)
        {
            List<Programación> lstMan = new List<Programación>();
            lstMan = blMan.listarPro(0, pIdUsuario, 0);
            dgvProgramacion.DataSource = lstMan;
        }

        private void txtDocumento_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDocumento.Text != "")
            {
                cl = blCliente.ClienteTraerPorDoc(Convert.ToInt32(txtDocumento.Text));
                txtNombre.Text = cl.CliNombres;
                txtApellido.Text = cl.CliApellidos;
            }
        }

        private void txtPlaca_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPlaca.Text != "")
            {
                ve = bLVehiculo.VehiculoTraerPorPlaca(cl.Id, txtPlaca.Text);
                txtMarca.Text = ve.Marca;
                txtClase.Text = ve.Clase;
            }

        }

        private void txtDocumentoMec_KeyUp(object sender, KeyEventArgs e)
        {
            List<Usuario> lstUsu = bLUsuario.ListarUsuarios();
            lstUsu.ForEach(u =>
            {
                if (u.IdPerfil == 3 && txtDocumentoMec.Text != "")
                {
                    if (u.Usu_Documento == Convert.ToInt32(txtDocumentoMec.Text))
                    {
                        IdUsuarioMec = u.IdUsuario;
                        txtNombreMec.Text = u.Usu_Nombre;
                        txtApellidoMec.Text = u.Usu_ApellidoPat + " " + u.Usu_ApellidoMat;
                    }
                }
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cl.Id == 0 || ve.Id == 0)
            {
                MessageBox.Show("Ingrese cliente o vehiculo");
            }
            else
            {
                man = new Mantenimiento();
                man.IdCliente = cl.Id;
                man.Idvehiculo = ve.Id;
                man.IdUsuario = IdUsuarioMec;
                man.Fecha = dtpFecha.Value;
                man.Obs = txtObs.Text;

                if (blMan.Insertar(man) == 1)
                {
                    MessageBox.Show("Ingreso correcto");
                    listarPro(0);
                }
                else
                    MessageBox.Show("No se ingreso");
            }
        }
    }
}
