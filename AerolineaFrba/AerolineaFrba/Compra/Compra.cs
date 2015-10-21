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
            validateAll(this.ComprarPasaje.Controls);
          try{  if (!this.Kgs.valid() && !this.CantPasaje.valid()) { 
            throw new Exception("Debe elegir kgs para mandar o cantidad de pasaje");
            }}
            catch(Exception exc){
            MessageBox.Show(exc.Message);
            }
            openIntoParent(new Elegir_Pasajeros(), this.MdiParent);
        }

        private void ViajeOk_Click(object sender, EventArgs e)
        {

        }

        private void OpcionesOk_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
