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
using AerolineaFrba.Model;

namespace AerolineaFrba.Compra
{
    public partial class Elegir_Pasajeros : Form
    {
        public Model.Viaje viaje { get; set; }
        public Model.Compra compra { get; set; }
        public DataGridView items { get { return grid_pasajeros; } }
        public Elegir_Pasajeros(Model.Compra compra)
        {
            InitializeComponent();
            this.compra = compra;
        }




        // si hay celdas vacias indica que la seleccione
        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (validarEncomiendasSinPasajes() || validarPasajesSinEncomiendas() || validarPasajesYEncomiendas())
            {

                //   if (superaElLimiteDeEncomiendas()) { MessageBox.Show("Los kgs de las encomiendas superan al límite que figura arriba"); return; }
                //  compra.codigo = DAO.DAOCompra.prepararCompra(grid_pasajeros, viaje.codigo);
                compra.codigoViaje = viaje.codigo;
                List<Item> pas = new List<Item>();
                foreach (DataGridViewRow row in grid_pasajeros.Rows) { 
                    pas.Add(getItem(row.Index)); }
                this.openIntoParent(new Efectuar_Compra(compra, pas), this.MdiParent);
            }
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
           
            //  KgsRestantes.Text += kgs_encomienda + " kg.";
            pasajesSinEncomiendas();
              pasajesYEncomiendas();
            encomiendasSinPasajes();



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
            if(grid_pasajeros.Rows.Count > 0){
                if (e.ColumnIndex == 1 && grid_pasajeros.cellValue("col_dni") != null && grid_pasajeros.cellValue("col_tipo_doc") != null)
                {
                    String dni = grid_pasajeros.cellValue("col_dni").ToString();
                    String tipoDNI = grid_pasajeros.cellValue("col_tipo_doc").ToString();
                    Boolean esPasaje = String.Equals(grid_pasajeros.cellValue("col_encomienda"), "0") ? true : false;
                    if (e.ColumnIndex == 1 && DAO.DAOCliente.existeCliente(tipoDNI, dni))
                    {

                        if (esPasaje && DAO.DAOCompra.clienteYaTienePasaje(viaje.fechaSalida, viaje.fechaLlegadaEstimada, tipoDNI, dni))
                        {
                            MessageBox.Show("El cliente tiene ya un pasaje en esa misma fecha");
                            // le seteo el documento en null para que no pueda seguir adelante 
                            grid_pasajeros.CurrentRow.Cells["col_dni"].Value = null;
                            return;

                        }

                        DAO.DAOCliente.completarDatos(tipoDNI, dni, grid_pasajeros);
                    }
                }
                if (grid_pasajeros.cellValue("col_fecha_nac") != null && e.ColumnIndex == grid_pasajeros.CurrentRow.Cells["col_fecha_nac"].ColumnIndex)
                {
                    DateTime date;


                    if (!DateTime.TryParse(grid_pasajeros.cellValue("col_fecha_nac"), out date))
                    {
                        MessageBox.Show("La fecha debe estar en el formato DD/MM/AAAA");
                        // lo borro para asegurarme de que no siga adelante con una fecha no valida
                        grid_pasajeros.CurrentRow.Cells["col_fecha_nac"].Value = null;
                        return;
                    }
                    grid_pasajeros.CurrentRow.Cells["col_fecha_nac"].Value = date.ToShortDateString();


                }
                
            }

            else { return; }

        }

        private Boolean superaElLimiteDeEncomiendas()
        {
            Decimal encomiendas = 0;
            foreach (DataGridViewRow row in grid_pasajeros.Rows)
            {
                Decimal value = row.Cells["col_encomienda"].Value == null ? 0 : Convert.ToDecimal(row.Cells["col_encomienda"].Value);
                encomiendas += value;
            }
            return encomiendas > viaje.encomiendas;
        }

        public decimal kgs_encomienda { get; set; }

        public decimal cant_pasajes { get; set; }

        private void elegirButaca_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(grid_pasajeros.CurrentRow.Cells["col_encomienda"].Value) == 0)
            {
                this.openInNewWindow(new Elegir_butacas(this, grid_pasajeros));
                return;
            }
            MessageBox.Show("No puede seleccionar butacas en encomiendas");
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


        private void pasajesSinEncomiendas()
        {
            if (cant_pasajes != 0 && kgs_encomienda == 0)
            {
                
                grid_pasajeros.Rows.Add(Convert.ToUInt16(cant_pasajes));
                grid_pasajeros.Columns["col_encomienda"].Visible = false;
                for (int i = 0; i < grid_pasajeros.Rows.Count; i++)
                {
                    grid_pasajeros.Rows[i].Cells["col_encomienda"].Value = 0;
                }

            }



        }

        private void encomiendasSinPasajes()
        {
            if (kgs_encomienda != 0 && cant_pasajes == 0)
            {
                grid_pasajeros.Rows.Add(1);
                grid_pasajeros.Columns["col_butaca"].Visible = false;
                grid_pasajeros.Columns["col_tipo"].Visible = false;
                elegirButaca.Enabled = false;
                grid_pasajeros.Rows[0].Cells["col_encomienda"].Value = kgs_encomienda;
                grid_pasajeros.Rows[0].Cells["col_encomienda"].ReadOnly = true;
            }
        }

        private Boolean validarEncomiendasSinPasajes()
        {
            if (kgs_encomienda != 0 && cant_pasajes == 0)
            {
                
                foreach (DataGridViewCell cell in grid_pasajeros.Rows[0].Cells)
                {
                    if ((cell.ColumnIndex != 8 && cell.ColumnIndex != 9) && cell.Value == null)
                    {

                        MessageBox.Show("Complete los datos");
                        return false;
                    }

                }
                return true;
            }
            return false;
        }

        private void pasajesYEncomiendas()
        {

            if (cant_pasajes != 0 && kgs_encomienda != 0)
            {
                int rows = Convert.ToUInt16(cant_pasajes) + 1;
                grid_pasajeros.Rows.Add(rows);
              for (int i = 0; i < grid_pasajeros.Rows.Count -1; i++)
                {
                    grid_pasajeros.Rows[i].Cells["col_encomienda"].Value = 0;

                }
                grid_pasajeros.Rows[grid_pasajeros.Rows.Count - 1].Cells["col_encomienda"].Value = kgs_encomienda;
                grid_pasajeros.Columns["col_encomienda"].ReadOnly = true;



            }
        }

        private Boolean validarPasajesYEncomiendas()
        {

            if (cant_pasajes != 0 && kgs_encomienda != 0)
            {

                foreach (DataGridViewRow row in grid_pasajeros.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null && cell.RowIndex == grid_pasajeros.Rows.Count - 1 && cell.ColumnIndex != 9 && cell.ColumnIndex != 8)
                        {
                            MessageBox.Show("Complete los datos de la encomienda"); return false;

                        }

                        if (cell.Value == null && cell.RowIndex != grid_pasajeros.Rows.Count - 1)
                        {
                            MessageBox.Show("Complete los datos de los pasajes"); return false;
                        }

                    }
                }
                return true;
            }
            return false;
        }

        private Boolean validarPasajesSinEncomiendas()
        {
            if (cant_pasajes != 0 && kgs_encomienda == 0)
            {
                foreach (DataGridViewRow row in grid_pasajeros.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {
                            MessageBox.Show("Ingrese los datos");
                            return false;

                        }

                    }
                }
                return true;
            }
            return false;
        }

        private void grid_pasajeros_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
        
            
            
        }

        private Item getItem(int row) {
            return new Item(grid_pasajeros.rowValue("col_tipo_doc", row),
                Convert.ToDecimal(grid_pasajeros.rowValue("col_dni", row)),
                grid_pasajeros.rowValue("col_nombre", row),
                grid_pasajeros.rowValue("col_apellido", row),
                grid_pasajeros.rowValue("col_direccion", row),
                Convert.ToDecimal(grid_pasajeros.rowValue("col_telefono", row)),
                grid_pasajeros.rowValue("col_mail", row),
                Convert.ToDateTime(grid_pasajeros.rowValue("col_fecha_nac", row)),
                Convert.ToDecimal(grid_pasajeros.rowValue("col_butaca", row)),
                grid_pasajeros.rowValue("col_tipo", row),
                Convert.ToDecimal(grid_pasajeros.rowValue("col_encomienda", row)));
        
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
