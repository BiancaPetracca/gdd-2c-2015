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
    public partial class Efectuar_Compra : Form
    {
        public Efectuar_Compra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exito_Tarjeta exitoTarjeta = new Exito_Tarjeta();
            exitoTarjeta.MdiParent = this;
            exitoTarjeta.Dock = DockStyle.Fill;
            exitoTarjeta.WindowState = FormWindowState.Maximized;
            exitoTarjeta.Show();
        }
    }
}
