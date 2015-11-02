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

namespace AerolineaFrba.Compra
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (! this.Pasaje.noRows("No hay ningún pasaje definido"))
            {
                this.openIntoParent(new Elegir_Pasajeros(), this.MdiParent);
            }
        }

        private void ViajeOk_Click(object sender, EventArgs e)
        {
            this.validateNotNullForAll(this.ElegirViaje.Controls);
            
        }

        private void OpcionesOk_Click(object sender, EventArgs e)
        {
            this.Servicio.validate();

            if (visibleFieldNotNull(this.Kgs) || visibleFieldNotNull(this.CantPasaje)) { }
            this.Pasaje.Rows.Add(this.FechaViaje.Value, this.CiudadOrigen.SelectedItem, this.CiudadDestino.SelectedItem, this.getValues(), this.Kgs.Value, this.CantPasaje.Value);
         
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Compra_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
      
           this.CiudadOrigen.AddAll(Extensions.listToStr(DAOCompra.listCiudades(), "nombre_ciudad"));
           this.CiudadDestino.AddAll(Extensions.listToStr(DAOCompra.listCiudades(), "nombre_ciudad"));
        }

        private Boolean visibleFieldNotNull(SuperNumericUpDown control)
        {
            return control.Visible && control.Value != 0;


        }
        private String getValues(){
            var str = "";
        foreach (var s in this.Servicio.CheckedItems)
        {
            str += s + "; " ;
        }
        return str;
           }

        private void CiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pasaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}