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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class Ciudad : Form
    {
        public Ciudad()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
           this.openInNewWindow(new Alta());
        }

        private void Borrar_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.lista.Columns["Modificar"].Index)
            {
                this.openIntoParent(new Modificacion(), this.MdiParent);
            }
        }


    }
}
