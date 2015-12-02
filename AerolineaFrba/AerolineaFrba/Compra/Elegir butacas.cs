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
    public partial class Elegir_butacas : Form
    {
        public Elegir_Pasajeros launcher { get; set; }
        public DataGridView grid_launcher { get; set; }
        public Elegir_butacas()
        {
            InitializeComponent();
        }

        public Elegir_butacas(Elegir_Pasajeros launcher, DataGridView grid_launcher)
        {
            InitializeComponent();
            this.launcher = launcher;
            this.grid_launcher = grid_launcher;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Decimal butaca = Convert.ToDecimal(grid.cellValue("col_butaca"));
            String tipo =   grid.cellValue("col_tipo").ToString();
            launcher.setButacaCurrentRow(butaca,tipo);
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Elegir_butacas_Load(object sender, EventArgs e)
        {
            DAO.DAOAeronave.getButacasDisponibles(launcher.viaje, grid);
        }


        private void disableSeleccionadas() {
            for (int i = 0; i < grid.Rows.Count; i++) { 
            if(butacasParciales(grid_launcher).Contains(Convert.ToString(grid.Rows[i].Cells["col_butaca"].Value))){
                grid.Rows.RemoveAt(i);
      }
            }
        
        }


        private List<String> butacasParciales(DataGridView dg) {
            List<String> butacas = new List<string>();
            foreach(DataGridViewRow row in dg.Rows){
                butacas.Add(Convert.ToString(row.Cells["col_butaca"].Value));     
            }
            return butacas;
        
        
        }
    }
}
