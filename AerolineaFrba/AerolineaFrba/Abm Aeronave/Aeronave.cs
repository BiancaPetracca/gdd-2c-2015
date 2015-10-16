using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Aeronave : Form
    {
        public Aeronave()
        {
            InitializeComponent();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Abm_Aeronave.Butacas butaca = new Butacas();
            butaca.Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Alta alta = new Alta();
            alta.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Modificacion modificacion = new Modificacion();
            modificacion.Show();
        }

        private void Aeronave_Load(object sender, EventArgs e)
        {

        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Baja baja = new Baja();
            baja.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
