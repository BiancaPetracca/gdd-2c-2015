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
    public partial class Modificacion : TemplateForm
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            validateNotNullForAll(this.DatosDelRol.Controls);
          
            // LLAMAR A UN PROCEDURE QUE BORRE DE LA BD LAS FUNCIONALIDADES QUE NO APARECEN ACA 
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            openIntoParent(new Modificacion(), this.MdiParent);
            this.Close();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarFunc_Click(object sender, EventArgs e)
        {
           this.dataGridView_ListaFuncionalidades.Rows.Add(this.Funcionalidades.SelectedValue);
        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataGridView_ListaFuncionalidades.Columns["Eliminar"].Index)
            {
                // en modificación solo lo borramos del datagrid porque no está persistido todavía en la BD
               
                this.dataGridView_ListaFuncionalidades.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            allowAlphaOnly(e);
        }

        private void DatosDelRol_Enter(object sender, EventArgs e)
        {

        }

    }
}
