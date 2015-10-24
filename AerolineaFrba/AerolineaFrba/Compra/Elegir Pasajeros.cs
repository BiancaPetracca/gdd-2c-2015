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

namespace AerolineaFrba.Compra
{
    public partial class Elegir_Pasajeros : Form
    {
        public Elegir_Pasajeros()
        {
            InitializeComponent();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (!this.DatosPasajes.anyEmptyCells("NumeroButaca", "Seleccione una butaca"))
            {
                this.openIntoParent(new Efectuar_Compra(), this.MdiParent);
            }
            
        }

        private void DatosPasajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.DatosPasajes.Columns["SeleccionarButaca"].Index)
            {
                this.openInNewWindow(new Abm_Aeronave.Butacas());
            }
        }

        // no funciona con el click en la celda, ni puta idea 
        private void SeleccionarButaca_Click(object sender, System.EventArgs e)
        {
           this.openInNewWindow(new Abm_Aeronave.Butacas());
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            // TODO borrar todo lo que habia hecho antes
            this.Close();
        }

 
    }
}
