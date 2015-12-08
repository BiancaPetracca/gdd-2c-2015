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
            Config.Terminal = 0; // estamos en una terminal aerolinea 
          if (!DAO.DAORol.rolEstaHabilitado(0)) { MessageBox.Show("El rol administrador se encuentra inhabilitado"); return; }
            this.openInNewWindow(new Login());
            this.Close();
        }

        private void but_cliente_Click(object sender, EventArgs e)
        {

            /* el cliente no puede ver: rol, ruta, aeronave, generar viaje, registro llegada, cancelacion, canje*/
            // le paso las funcionalidades del cliente 
           if (!DAO.DAORol.rolEstaHabilitado(1)) { MessageBox.Show("El rol cliente se encuentra inhabilitado"); return; }
            List<Decimal> funcionalidadesCliente = DAO.DAORol.getIdFuncionalidades(1); 

            // le indico que es el rol1, el cliente.
            MainMenu menu = new MainMenu(funcionalidadesCliente, 1);
            Config.Terminal = 1;  //indico que estamos en la terminal kiosco esto es para las compras luego
            this.openInNewWindow(menu);
            this.Close();
            
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

    }
}
