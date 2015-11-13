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

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.validateNotNullForAll(this.Controls);
            ReemplazarOCancelar form = new ReemplazarOCancelar();
            form.setTipoDeBaja(this.MotivoBajaAeronave.SelectedIndex, this.matricula, this.fechaBaja.Value, this.fechaReinicio.Value.ToString());
            this.openInNewWindow(form);


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

    }
}
