using AerolineaFrba.SuperControls;
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
using AerolineaFrba.Model;

namespace AerolineaFrba.Compra
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        public Compra(Model.Compra compra) {
            InitializeComponent();
            this.compra = compra;
        }

        public Model.Viaje viaje { get; set; }
        private Model.Compra compra;

        // setea los datos del vuelo 
        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (! this.Pasaje.noRows("No hay ningún pasaje definido"))
            {
                Elegir_Pasajeros elegirPasajeros = new Elegir_Pasajeros();
                elegirPasajeros.setFlightData(this.viaje, cant_pasajes.value, encomienda.value);

                this.openIntoParent(elegirPasajeros, this.MdiParent);
            }
        }

        private void ViajeOk_Click(object sender, EventArgs e)
        {
            if (this.validateNotNullForAll(this.ElegirViaje.Controls)) {
if (!this.validateDomain(Validations.criteriumMessage(()=>fechaSalida.value == fechaLlegada.value,"Las fechas no pueden ser iguales"),
    Validations.criteriumMessage(()=>CiudadDestino.value == CiudadOrigen.value, "No pueden coincidir las ciudades origen y destino"))){
      
    Model.Viaje viaje = new Viaje(CiudadOrigen.value, CiudadDestino.value, this.fechaSalida.value, fechaLlegada.value);
    if (DAO.DAOCompra.hayViajesDisponibles(viaje))
    {
        this.openInNewWindow(new SeleccionarViaje(this, viaje));
        return;
    }
    MessageBox.Show("No hay viajes disponibles con estos datos");
}
                }
            
            }
              

        

        // obtiene los servicios
        public String getValues() { 
            var str  = "";
            if (this.encomienda.Value != 0)
            {
                str += "Encomienda; ";
            }
            if (this.cant_pasajes.Value != 0) {
                str += "Pasajes";
            }
            return str;
        }

        // valida que no haya nada vacio
        private void OpcionesOk_Click(object sender, EventArgs e)
        {
            if (!this.validateNotNullForAll(this.ElegirViaje.Controls))
            {
                return;
            }

                if (this.encomienda.valid() || this.cant_pasajes.valid())
                {
                     this.Pasaje.Rows[0].Cells["col_butacas"].Value = cant_pasajes.value;
                     this.Pasaje.Rows[0].Cells["col_encomiendas"].Value = encomienda.value;
                }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
           
        }
        // carga las ciudades 
        private void Compra_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
     
           this.CiudadOrigen.AddAll(DAO.DAOCompra.listarCiudades());
           this.CiudadDestino.AddAll(DAO.DAOCompra.listarCiudades());
        }


        private void CiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pasaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Kgs_ValueChanged(object sender, EventArgs e)
        {

        }

        internal void setViaje(DataGridViewRow dataGridViewRow)
        {
            Pasaje.Rows.Add(dataGridViewRow);
        }

        public void setViaje(Model.Viaje viaje) {
            this.viaje = viaje;
            Pasaje.Rows.Add(viaje.codigo, viaje.codigo, viaje.fechaSalida, viaje.fechaLlegadaEstimada, viaje.ciudadOrigen, viaje.ciudadDestino, viaje.servicio);
        }
    }




    }
