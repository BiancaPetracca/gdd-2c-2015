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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            this.label2.Hide();
            this.fechaReinicio.Hide();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.validateNotNullForAll(this.Controls);
            ReemplazarOCancelar form = new ReemplazarOCancelar();
            form.setTipoDeBaja(this.MotivoBajaAeronave.SelectedIndex, this.matricula, this.fechaBaja.Value, this.fechaReinicio.Value);
            this.openInNewWindow(form);
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e) // para la fecha de reinicio
        {
            Show(new MonthCalendar());
        }

        private void button1_Click(object sender, EventArgs e)  // para la fecha de baja
        {
            Show(new MonthCalendar());
        }

        public void setBajaAeronave(String matricula) {

            this.matricula = matricula;
}

        private void MotivoBajaAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MotivoBajaAeronave.SelectedIndex == 1)
            {
                this.label2.Show();
                this.fechaReinicio.Show();
            }
            else {
                this.label2.Hide();
                this.fechaReinicio.Hide();
            }
        }

    }
}
