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
    public partial class Exito_Efectivo : Form
    {
        public Exito_Efectivo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Detalle_Compra detalle = new Detalle_Compra();
            detalle.MdiParent = this.MdiParent;
            detalle.Dock = DockStyle.Fill;
            detalle.WindowState = FormWindowState.Maximized;
            detalle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
