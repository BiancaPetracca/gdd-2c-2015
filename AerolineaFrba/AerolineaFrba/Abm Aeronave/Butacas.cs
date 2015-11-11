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
    public partial class Butacas : Form
    {

        // no sabemos si dejar este form o no y hacerlo de forma que solo me indique el tipo de butaca que es 
        // y yo solo ingreso el numero
        public Butacas()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            try { validate(); }
            catch(Exception exception){
            MessageBox.Show(exception.Message);
            }
          
        }

        private void validate() {
            foreach (DataGridViewRow rw in this.grid.Rows)
            {
                if (rw.Cells["Tipo"].Value == null)
                {
                    throw new Exception("Debe elegir al menos un tipo de butaca");

                }

            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
