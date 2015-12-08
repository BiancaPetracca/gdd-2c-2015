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
            if (! Pasaje.noRows("No hay ningún pasaje definido"))
            {
                Decimal pasajes = Pasaje.Rows[0].Cells["col_pasajes"].Value == null? 0: Convert.ToDecimal(Pasaje.Rows[0].Cells["col_pasajes"].Value);
                Decimal encomiendas = Pasaje.Rows[0].Cells["col_encomiendas"].Value == null ? 0 : Convert.ToDecimal(Pasaje.Rows[0].Cells["col_encomiendas"].Value);
                    Elegir_Pasajeros elegirPasajeros = new Elegir_Pasajeros(compra);
                    elegirPasajeros.setFlightData(viaje, pasajes, encomiendas);

                    this.openIntoParent(elegirPasajeros, MdiParent);
    
            }
        }

        private void ViajeOk_Click(object sender, EventArgs e)
        {
            if (this.validateNotNullForAll(ElegirViaje.Controls)) {
            if (this.validateDomain(
                Validations.criteriumMessage(()=>fechaSalida.value != fechaLlegada.value,"Las fechas no pueden ser iguales"),
                Validations.criteriumMessage(()=>CiudadDestino.value != CiudadOrigen.value, "No pueden coincidir las ciudades origen y destino"))){
                    encomienda.clean(); cant_pasajes.clean(); Pasaje.Refresh();
             Model.Viaje viaje = new Viaje(CiudadOrigen.value, CiudadDestino.value, fechaSalida.value, fechaLlegada.value);
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
            if (encomienda.Value != 0)
            {
                str += "Encomienda; ";
            }
            if (cant_pasajes.Value != 0) {
                str += "Pasajes";
            }
            return str;
        }

        // valida que no haya nada vacio
        private void OpcionesOk_Click(object sender, EventArgs e)
        {
            if (!this.validateNotNullForAll(ElegirViaje.Controls))
            {
                return;
            }

                if ((encomienda.valid() || cant_pasajes.valid()) && Pasaje.Rows.Count > 0)
                {
                   

                     this.Pasaje.Rows[0].Cells["col_pasajes"].Value = cant_pasajes.value;
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

            this.fechaSalida.MinDate = Config.DateToday;
            this.fechaLlegada.MinDate = this.fechaSalida.Value;
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

        public void setViaje(Model.Viaje viaje) {
            this.viaje = viaje;
            encomienda.Maximum = viaje.encomiendas;
            cant_pasajes.Maximum = viaje.butacasDisponibles;
            Pasaje.Rows.Clear();
            Pasaje.Rows.Add(viaje.codigo, viaje.fechaSalida, viaje.fechaLlegadaEstimada, viaje.ciudadOrigen, viaje.ciudadDestino, viaje.servicio);
        }

        private void fechaSalida_ValueChanged(object sender, EventArgs e)
        {
            this.fechaLlegada.MinDate = fechaSalida.value;
        }

        private void ComprarPasaje_Enter(object sender, EventArgs e)
        {

        }
    }




    }
