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
    public partial class SeleccionarViaje : Form
    {
        private Model.Viaje viaje;
        private Compra launcher;
    

        public SeleccionarViaje()
        {
            InitializeComponent();
        }

        public SeleccionarViaje(Compra launcher, Model.Viaje viaje)
        {
            InitializeComponent();
            this.launcher = launcher;
            this.viaje = viaje;
        }

        private void SeleccionarViaje_Load(object sender, EventArgs e)
        {
            DAO.DAOCompra.encontrarViajes(this.viajes, viaje.ciudadOrigen, viaje.ciudadDestino, viaje.fechaSalida, viaje.fechaLlegadaEstimada);
        }

        private void seleccionar_viaje_Click(object sender, EventArgs e)
        {
            if (this.viajes.SelectedRows.Count == 0 || this.viajes.SelectedCells.Count == 0) {

                MessageBox.Show("Seleccione un viaje");
                return;
            }
            Model.Viaje viajeElegido = new Model.Viaje(
                Convert.ToDecimal(viajes.cellValue("col_codigo")),
                Convert.ToDateTime(viajes.cellValue("col_salida")),
                Convert.ToDateTime(viajes.cellValue("col_estimada")),
                Convert.ToString(viajes.cellValue("col_origen")),
                Convert.ToString(viajes.cellValue("col_destino")),
                Convert.ToString(viajes.cellValue("col_servicio")),
                Convert.ToDecimal(viajes.cellValue("col_butacas")),
                Convert.ToDecimal(viajes.cellValue("col_encomiendas")));
            this.launcher.setViaje(viajeElegido);
        }
    }
}
