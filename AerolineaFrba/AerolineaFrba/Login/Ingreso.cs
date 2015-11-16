using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Generics;

namespace AerolineaFrba.Login
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void but_admin_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Login());
            this.Close();
        }

        private void but_cliente_Click(object sender, EventArgs e)
        {

            /* el cliente no puede ver: rol, ruta, aeronave, generar viaje, registro llegada, cancelacion, canje*/
            MainMenu menu = new MainMenu();
            menu.Terminal = 1; // le indico que estamos en la terminal kiosco 
            menu.visibilidadCliente();
            this.openInNewWindow(menu);
            this.Close();
            
        }

    }
}
