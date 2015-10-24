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
    public partial class RolListado : TemplateForm
    {
        public RolListado()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            openIntoParent(new Alta(), this.MdiParent);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_SeleccionRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.ListadoRoles.Columns["Modificar"].Index)
            {
                openIntoParent(new Modificacion(), this.MdiParent);
            }
           
        }
    }
}
