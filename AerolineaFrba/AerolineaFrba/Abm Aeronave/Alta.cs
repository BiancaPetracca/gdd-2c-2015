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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void fabricante_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.validarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void lugar_butacas_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Butacas butacas = new Butacas();
            butacas.Show();
        }

        private void validarCampos()
        {
            var valido = true;

            foreach (var control in this.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) valido = false;
            }

            if (!valido){
            throw new MissingFieldException("Campos vacíos");
            }

        }
    }
}
