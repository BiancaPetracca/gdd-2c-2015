using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaSaldo_Click(object sender, EventArgs e)
        {

        }

        private void operacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolABM_Click(object sender, EventArgs e)
        {
            Abm_Rol.Listado a = new Abm_Rol.Listado();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.WindowState = FormWindowState.Maximized;
            a.Show();

        }

        private void aeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Aeronave aeronave = new Abm_Aeronave.Aeronave();
            aeronave.MdiParent = this;
            aeronave.Dock = DockStyle.Fill;
            aeronave.WindowState = FormWindowState.Maximized;
            aeronave.Show();

        }

    }
}
