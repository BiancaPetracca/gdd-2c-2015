using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Ruta : TemplateForm
    {
        public Ruta()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            openInNewWindow(new Alta());
        }


        private void Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {

        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.lista.Columns["Modificar"].Index)
            {
                openIntoParent(new Modificacion(), this.MdiParent);
            }

            if (e.ColumnIndex == this.lista.Columns["Eliminar"].Index)
            {
                // LLAMAR AL PROCEDURE QUE LA BORRE 
                this.lista.Rows.RemoveAt(e.RowIndex);
            }


        }
    }
}