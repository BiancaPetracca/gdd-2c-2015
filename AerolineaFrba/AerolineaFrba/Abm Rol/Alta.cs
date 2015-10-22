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
    public partial class Alta : TemplateForm
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void paner_Alta_Enter(object sender, EventArgs e)
        {

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            validateNotNullForAll(this.DatosDelRol.Controls);
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            validateNotNullForAll(this.Controls);
        }
    }
}
