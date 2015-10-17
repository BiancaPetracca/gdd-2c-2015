using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            Elegir_Pasajeros elegirPasajeros = new Elegir_Pasajeros();
            elegirPasajeros.MdiParent = this.MdiParent;
            this.Close();
            elegirPasajeros.Dock = DockStyle.Fill;
            elegirPasajeros.WindowState = FormWindowState.Maximized;
            elegirPasajeros.Show();
        }
    }
}
