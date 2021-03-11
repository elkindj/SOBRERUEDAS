using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Negocios;

namespace TallerMecanico
{
    public partial class FrmUsuario : Form
    {
        BLUsuario bLUsuario = new BLUsuario();
        public FrmUsuario()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            gridUsuarios.AutoGenerateColumns = false;
            gridUsuarios.DataSource = bLUsuario.ListarUsuarios();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
