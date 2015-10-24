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
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
            if (FuncionalidadSeleccion.SelectedIndex != -1) {
                FuncionalidadesRol.Rows.Add(FuncionalidadSeleccion.SelectedItem);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FuncionalidadesRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
