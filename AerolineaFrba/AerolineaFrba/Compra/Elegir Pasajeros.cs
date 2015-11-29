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
        public Model.Viaje viaje { get; set; }
        public Elegir_Pasajeros()
        {
            InitializeComponent();
        }


        
        // si hay celdas vacias indica que la seleccione
        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (!this.pasajeros.anyEmptyCells("NumeroButaca", "Seleccione una butaca"))
            {
              
                this.openIntoParent(new Efectuar_Compra(), this.MdiParent);
            }
            
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
        public void setFlightData(Model.Viaje viaje, Decimal cant_pasajes, Decimal kgs_encomienda) {
            this.viaje = viaje;
            this.cant_pasajes = cant_pasajes;
            this.kgs_encomienda = kgs_encomienda;
        }
        // añade tantas filas como maximo de butacas hay 
        private void Elegir_Pasajeros_Load(object sender, EventArgs e)
        {
            KgsRestantes.Text += kgs_encomienda + "kg.";
            this.pasajeros.Rows.Add();
            this.pasajeros.Rows.AddCopies(0, (int)Decimal.Round(cant_pasajes, 0));
            allowed_sum = true;
        }

        // suma todos los valores de las encomiendas que fue agregando el usuario
        private Decimal sumNumerics() {
            int sum = 0;
            foreach (DataGridViewRow row in this.pasajeros.Rows) {
               sum = sum + (int)row.Cells["col_encomiendas"].Value;
            }
            this.restantes = viaje.encomiendas - sum;
            return sum;
        }

        private void DatosPasajes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int dni = (int)pasajeros.cellValue("col_dni");
            if (e.ColumnIndex == 1 && DAO.DAOCliente.existeCliente(dni))
            {
                DAO.DAOCliente.completarDatos(dni, pasajeros);
            }
        }

        private bool allowed_sum = false;

    

        public decimal kgs_encomienda { get; set; }

        public decimal cant_pasajes { get; set; }

        private void elegirButaca_Click(object sender, EventArgs e)
        {
            if (pasajeros.SelectedCells.Count != 0 || pasajeros.SelectedRows.Count != 0)
            {
                this.openInNewWindow(new Elegir_butacas(this));
                return;
            }
            MessageBox.Show("Seleccione un pasajero");
        }

        public void setButacaCurrentRow(Decimal butaca, String tipo)
        {
            int current = pasajeros.CurrentRow.Index;
            pasajeros.Rows[current].Cells["col_butaca"].Value = butaca;
            pasajeros.Rows[current].Cells["col_tipo"].Value = tipo;
        }

        private void quitar_Click(object sender, EventArgs e)
        {
            int current = pasajeros.CurrentRow.Index;
            if (pasajeros.Rows[current].Cells["col_butaca"].Value != null)
            {
                DAO.DAOAeronave.modificarEstadoButaca(viaje.codigo,
                    Convert.ToDecimal(pasajeros.Rows[current].Cells["col_butaca"].Value),
                    0);
                pasajeros.Rows[current].Cells["col_butaca"].Value = null;
                pasajeros.Rows[current].Cells["col_tipo"].Value = null;
                return;
            }
            MessageBox.Show("Seleccione un pasajero");
        }

        
    }
}
