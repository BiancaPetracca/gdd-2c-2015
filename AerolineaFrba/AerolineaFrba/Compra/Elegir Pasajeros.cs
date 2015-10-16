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
    public partial class Elegir_Pasajeros : Form
    {
        public Elegir_Pasajeros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Efectuar_Compra efectuar = new Efectuar_Compra();
            efectuar.MdiParent = this;
            efectuar.Dock = DockStyle.Fill;
            efectuar.WindowState = FormWindowState.Maximized;
            efectuar.Show();
        }
    }
}
