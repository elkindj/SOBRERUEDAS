using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD

            //Application.Run(new FrmClientes());
            Application.Run(new FrmLogin());
            //Application.Run(new FrmUsuario());
=======
            Application.Run(new FrmLogin());
>>>>>>> 57599af1ad4ac92e6cf24c15b677370e7df3e891
        }
    }
}
