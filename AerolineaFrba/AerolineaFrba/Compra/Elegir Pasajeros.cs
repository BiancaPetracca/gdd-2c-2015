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
        private int terminal = 0;
        public Elegir_Pasajeros()
        {
            InitializeComponent();
        }

        public Elegir_Pasajeros(int terminal)
        {
            InitializeComponent();
            this.terminal = terminal;
        }
        
        // si hay celdas vacias indica que la seleccione
        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (!this.DatosPasajes.anyEmptyCells("NumeroButaca", "Seleccione una butaca"))
            {
                this.openIntoParent(new Efectuar_Compra(this.terminal), this.MdiParent);
            }
            
        }

        private void DatosPasajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // seleccionar butaca
            if (e.ColumnIndex == 7)
            {
                this.openInNewWindow(new Abm_Aeronave.Butacas());
            }
            // que se actualice lo que resta de kgs para mandar 
            if (e.ColumnIndex == 8){
            this.restantes = this.maximoEncomiendas - this.sumNumerics();
            }
        }
   // no sabemos si dejarlo asi o no o que sea un combobox
        private void SeleccionarButaca_Click(object sender, System.EventArgs e)
        {
           this.openInNewWindow(new Abm_Aeronave.Butacas());
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            // TODO borrar todo lo que habia hecho antes
            this.Close();
        }

        public String getRestantes() {
           return  this.restantes.ToString();
        }

        // setea los datos del vuelo
        public void setFlightData(String origen, String destino, Decimal maximoEncomiendas1, Decimal maximoButacas1, DateTime fecha, Decimal restantes1) {
            this.origen = origen;
            this.destino = destino;
            this.maximoEncomiendas = maximoEncomiendas1;
            this.maximoButacas = maximoButacas1;
            this.fecha = fecha;
            this.restantes = restantes1;
        }
        // añade tantas filas como maximo de butacas hay 
        private void Elegir_Pasajeros_Load(object sender, EventArgs e)
        {
            int max = (int)(Decimal.Round(this.maximoButacas, 0));
            this.DatosPasajes.Rows.Add();
            this.DatosPasajes.Rows.AddCopies(0, max);
            allowed_sum = true;
        }

        // suma todos los valores de las encomiendas que fue agregando el usuario
        private Decimal sumNumerics() {
            int sum = 0;
            foreach (DataGridViewRow row in this.DatosPasajes.Rows) {
               sum = sum + (int)row.Cells[8].Value;
            }
            this.restantes = this.maximoEncomiendas - sum;
            return sum;
        }

        private void DatosPasajes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8 && allowed_sum)
            this.sumNumerics();
        }

        private bool allowed_sum = false;

 
    }
}
