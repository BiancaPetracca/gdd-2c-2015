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

namespace AerolineaFrba.Compra
{
    public partial class Compra : TemplateForm
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (!noRows(this.Pasaje, "No hay ningún pasaje definido"))
            {
                openIntoParent(new Elegir_Pasajeros(), this.MdiParent);
            }
        }

        private void ViajeOk_Click(object sender, EventArgs e)
        {
            validateNotNullForAll(this.ElegirViaje.Controls);
        }

        private void OpcionesOk_Click(object sender, EventArgs e)
        {
            validate(this.Servicio);

            if (visibleFieldNotNull(this.Kgs) || visibleFieldNotNull(this.CantPasaje)) { }
           
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Compra_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private Boolean visibleFieldNotNull(SuperNumericUpDown control)
        {
            return control.Visible && control.Value != 0;


        }
    }
}