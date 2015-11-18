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

        private Model.Compra compra;

        // setea los datos del vuelo 
        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (! this.Pasaje.noRows("No hay ningún pasaje definido"))
            {
                Elegir_Pasajeros form = new Elegir_Pasajeros(compra.Terminal);
                form.setFlightData(this.CiudadOrigen.SelectedItem.ToString(), this.CiudadDestino.SelectedItem.ToString(), this.Kgs.Value, this.CantPasaje.Value, this.FechaViaje.Value, this.Kgs.Value);

                this.openIntoParent(form, this.MdiParent);
            }
        }

        private void ViajeOk_Click(object sender, EventArgs e)
        {
            this.validateNotNullForAll(this.ElegirViaje.Controls);
              

        }


        // obtiene los servicios
        public String getValues() { 
            var str  = "";
            if (this.Kgs.Value != 0)
            {
                str += "Encomienda; ";
            }
            if (this.CantPasaje.Value != 0) {
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

                if (this.Kgs.valid() || this.CantPasaje.valid())
                {
                    this.Pasaje.Rows.Add(this.FechaViaje.Value, this.CiudadOrigen.SelectedItem, this.CiudadDestino.SelectedItem, this.getValues(), this.Kgs.Value, this.CantPasaje.Value);
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
        }




    }
