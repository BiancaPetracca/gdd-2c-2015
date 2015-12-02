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
using AerolineaFrba.DAO;
using System.Globalization;

namespace AerolineaFrba.Compra
{
    public partial class Elegir_Pasajeros : Form
    {
        public Model.Viaje viaje { get; set; }
        public Model.Compra compra { get; set; }
        public Elegir_Pasajeros(Model.Compra compra)
        {
            InitializeComponent();
            this.compra = compra;
        }




        // si hay celdas vacias indica que la seleccione
        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (grid_pasajeros.anyEmptyCells()) { MessageBox.Show("Debe completar todos los datos de todas las personas que viajan"); return; }
            if (superaElLimiteDeEncomiendas()) { MessageBox.Show("Los kgs de las encomiendas superan al límite que figura arriba"); return; }
                compra.codigo = DAO.DAOCompra.prepararCompra(grid_pasajeros, viaje.codigo);
                this.openIntoParent(new Efectuar_Compra(compra), this.MdiParent);
                return;
            }




        private void Cancelar_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("Compra cancelada!");
            this.Close();
        }

        public String getRestantes()
        {
            return this.restantes.ToString();
        }

        // setea los datos del vuelo
        public void setFlightData(Model.Viaje viaje, Decimal cant_pasajes, Decimal kgs_encomienda)
        {
            
            this.viaje = viaje;
            this.cant_pasajes = cant_pasajes;
            this.kgs_encomienda = kgs_encomienda;
        }
        // añade tantas filas como maximo de butacas hay 
        private void Elegir_Pasajeros_Load(object sender, EventArgs e)
        {
            KgsRestantes.Text += kgs_encomienda + "kg.";
            int pasajes = (int)Decimal.Round(cant_pasajes, 0);
            if (pasajes == 0) { this.grid_pasajeros.Rows.Add(1); return; }
            this.grid_pasajeros.Rows.Add((int)Decimal.Round(cant_pasajes, 0));
          
        }

        // suma todos los valores de las encomiendas que fue agregando el usuario
        private Decimal sumNumerics()
        {
            Decimal sum = 0;
            foreach (DataGridViewRow row in this.grid_pasajeros.Rows)
            {
                sum = sum + Convert.ToDecimal(row.Cells["col_encomiendas"].Value);
            }
            this.restantes = viaje.encomiendas - sum;
            return sum;
        }

        private void DatosPasajes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_pasajeros.CurrentRow != null || grid_pasajeros.CurrentCell != null)
            {
                if (grid_pasajeros.cellValue("col_dni") != null && grid_pasajeros.cellValue("col_tipo_doc") != null)
                {
                    String dni = grid_pasajeros.cellValue("col_dni").ToString();
                    String tipoDNI = grid_pasajeros.cellValue("col_tipo_doc").ToString();
                    if (e.ColumnIndex == 1 && DAO.DAOCliente.existeCliente(tipoDNI, dni))
                 
                        DAO.DAOCliente.completarDatos(tipoDNI, dni, grid_pasajeros);
                    }
                if(grid_pasajeros.CurrentRow.Cells["col_fecha_nac"] != null && e.ColumnIndex == grid_pasajeros.CurrentRow.Cells["col_fecha_nac"].ColumnIndex){
                    DateTime date;
                   
                    
                if (!DateTime.TryParse(Convert.ToString(grid_pasajeros.CurrentRow.Cells["col_fecha_nac"].Value), out date)){
                    MessageBox.Show("no es un formato valido");
                    return;
                }
                grid_pasajeros.CurrentRow.Cells["col_fecha_nac"].Value = date.ToShortDateString();


                
                }
                }
            
            else { return; }

        }

        private Boolean superaElLimiteDeEncomiendas(){
            Decimal encomiendas = 0;
            foreach(DataGridViewRow row in grid_pasajeros.Rows) {
                Decimal value = row.Cells["col_encomienda"].Value == null ? 0 : Convert.ToDecimal(row.Cells["col_encomienda"].Value);
                encomiendas += value;  }
            return encomiendas > viaje.encomiendas;
        }

        public decimal kgs_encomienda { get; set; }

        public decimal cant_pasajes { get; set; }

        private void elegirButaca_Click(object sender, EventArgs e)
        {
            if (grid_pasajeros.SelectedCells.Count != 0 || grid_pasajeros.SelectedRows.Count != 0)
            {
                this.openInNewWindow(new Elegir_butacas(this, grid_pasajeros));
                return;
            }
            MessageBox.Show("Seleccione un pasajero");
        }

        public void setButacaCurrentRow(Decimal butaca, String tipo)
        {
            int current = grid_pasajeros.CurrentRow.Index;
            grid_pasajeros.Rows[current].Cells["col_butaca"].Value = butaca;
            grid_pasajeros.Rows[current].Cells["col_tipo"].Value = tipo;
        }

        private void quitar_Click(object sender, EventArgs e)
        {
            int current = grid_pasajeros.CurrentRow.Index;
            if (grid_pasajeros.Rows[current].Cells["col_butaca"].Value != null)
            {
                DAO.DAOAeronave.modificarEstadoButaca(viaje.codigo,
                    Convert.ToDecimal(grid_pasajeros.Rows[current].Cells["col_butaca"].Value),
                    0);
                grid_pasajeros.Rows[current].Cells["col_butaca"].Value = null;
                grid_pasajeros.Rows[current].Cells["col_tipo"].Value = null;
                return;
            }
            MessageBox.Show("Seleccione un pasajero");
        }

        private void grid_pasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
}
}
