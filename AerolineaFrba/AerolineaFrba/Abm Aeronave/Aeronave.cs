using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Aeronave : TemplateForm
    {
        public Aeronave()
        {
            InitializeComponent();
        }



        private void Agregar_Click(object sender, EventArgs e)
        {
            openInNewWindow(new Alta());
        }
      

        private void Borrar_Click(object sender, EventArgs e)
        {
            openInNewWindow(new Baja());
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Modificacion modificacion = new Modificacion();
            modificacion.Show();
        }

        private void VerButacas_Click(object sender, EventArgs e)
        {
            Butacas butacas = new Butacas();
            butacas.Show();
        }

        private void MatriculaFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            allowNumericOnly(e);
        }

        private void FabricanteFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            allowAlphaOnly(e);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
