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
            if (!this.grid_pasajeros.anyEmptyCells())
            {
                Decimal codigoCompra = DAO.DAOCompra.prepararCompra(grid_pasajeros);
         
                this.openIntoParent(new Efectuar_Compra(codigoCompra), this.MdiParent);
            }
            MessageBox.Show("Debe completar todos los datos de todas las personas que viajan");

        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            // TODO borrar todo lo que habia hecho antes
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
            this.grid_pasajeros.Rows.Add((int)Decimal.Round(cant_pasajes, 0));
            allowed_sum = true;
        }

        // suma todos los valores de las encomiendas que fue agregando el usuario
        private Decimal sumNumerics()
        {
            int sum = 0;
            foreach (DataGridViewRow row in this.grid_pasajeros.Rows)
            {
                sum = sum + (int)row.Cells["col_encomiendas"].Value;
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
                }
            
            else { return; }

        }

        private bool allowed_sum = false;



        public decimal kgs_encomienda { get; set; }

        public decimal cant_pasajes { get; set; }

        private void elegirButaca_Click(object sender, EventArgs e)
        {
            if (grid_pasajeros.SelectedCells.Count != 0 || grid_pasajeros.SelectedRows.Count != 0)
            {
                this.openInNewWindow(new Elegir_butacas(this));
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

        private void pasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pasajeros_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        { 


            if (e.ColumnIndex == grid_pasajeros.Rows[0].Cells["col_fecha_nac"].ColumnIndex)
            {
                    Rectangle tempRect = this.grid_pasajeros.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    cellDateTimePicker.Location = tempRect.Location;
                    cellDateTimePicker.Width = tempRect.Width;
                    try
                    {
                        cellDateTimePicker.Value = DateTime.Parse(grid_pasajeros.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        cellDateTimePicker.Value = Config.DateToday;
                    }
                    cellDateTimePicker.Visible = true;
                }
            if (onlyNumbers.Contains(e.ColumnIndex)){
            } 
            
        }
        void cellDateTimePickerValueChanged(object sender, EventArgs e)
        {
            grid_pasajeros.CurrentCell.Value = cellDateTimePicker.Value.ToString("dd/MM/yyyy");
            cellDateTimePicker.Visible = false;
        }

        private void AddCalendars(DataGridView dtgv)
        {
            dateColumnsIndexes = new List<int>();
            var l = dtgv.Columns.Count;
            string[] dateColumns = { "date_received", "date_of_birth" };
            for (var i = 0; i < l; ++i)
            {
                if (dateColumns.Any(dtgv.Columns[i].HeaderText.Contains))
                {
                    dateColumnsIndexes.Add(i);
                }
            }



        }

        private void pasajeros_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
                Validations.columnAsTextBox(grid_pasajeros, onlyNumbers, e);
           
        }
    
         private List<int> onlyNumbers =  new List<int>(new int[] {1,5,10});

}
}
