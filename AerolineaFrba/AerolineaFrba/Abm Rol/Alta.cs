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

namespace AerolineaFrba.Abm_Rol
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (! FuncionalidadesRol.anyEmptyCells("Funcionalidades", "El rol debe tener al menos una funcionalidad")) { 
                // llamar al procedure!
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (Funcionalidad.SelectedIndex != -1) {
                FuncionalidadesRol.Rows.Add(Funcionalidad.SelectedItem);
            }
            Funcionalidad.ResetText();
        }

        private void FuncionalidadesRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
