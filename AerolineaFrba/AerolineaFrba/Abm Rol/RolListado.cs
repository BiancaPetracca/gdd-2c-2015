using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class RolListado : Form
    {
        public RolListado()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Abm_Rol.Alta alta = new Alta();
            alta.Show();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_SeleccionRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Abm_Rol.Modificacion modificacion = new Modificacion();
            modificacion.Show();
        }
    }
}
