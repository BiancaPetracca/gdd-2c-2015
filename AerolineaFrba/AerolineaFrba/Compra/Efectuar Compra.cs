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
            if (comboBox1.ValueMember == "Efectivo")
            {
                Exito_Efectivo exitoEfectivo = new Exito_Efectivo();
                exitoEfectivo.MdiParent = this.MdiParent;
                exitoEfectivo.Dock = DockStyle.Fill;
                exitoEfectivo.WindowState = FormWindowState.Maximized;
                this.Close();
                exitoEfectivo.Show();
            }
            else
            {

                Exito_Tarjeta exitoTarjeta = new Exito_Tarjeta();
                exitoTarjeta.MdiParent = this.MdiParent;
                exitoTarjeta.Dock = DockStyle.Fill;
                exitoTarjeta.WindowState = FormWindowState.Maximized;
                this.Close();
                exitoTarjeta.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
