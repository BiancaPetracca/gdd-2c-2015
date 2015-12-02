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

        private Abm_Aeronave.Aeronave launcherBaja;
        public Abm_Aeronave.Aeronave LauncherBaja { get { return launcherBaja; } set { launcherBaja = value; } }
        public Decimal numero { get; set; }
        public String matricula { get; set; }
        public Baja(Decimal numero, String matricula)
        {
            this.numero = numero;
            this.matricula = matricula;
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
            String fechaDefault = "01/01/1800 12:00:00";
            // Si tiene viajes asignados posteriores, hay que asignarselos a otra aeronave. 
            int asignados;
            if (this.MotivoBajaAeronave.SelectedIndex == 0) {
                asignados = DAO.DAOAeronave.tieneViajesAsignados(this.numero, this.fechaBaja.value, Convert.ToDateTime(fechaDefault));
            }
            else{
             asignados = DAO.DAOAeronave.tieneViajesAsignados(this.numero, this.fechaBaja.value, this.fechaReinicio.value);
            }
            if(asignados == 1){
                ReemplazarOCancelar form = new ReemplazarOCancelar(numero);
                form.BajaLauncher = this.LauncherBaja;
                form.setTipoDeBaja(this.MotivoBajaAeronave.SelectedIndex, this.matricula, this.fechaBaja.value, this.fechaReinicio.Value);
                this.openInNewWindow(form);
            }
            else
            { // Si no tiene viajes asignados, entonces directamente se da de baja a la aeronave y listo. 
                if (MotivoBajaAeronave.value == "Mantenimiento")
                {
                    DAO.DAOAeronave.bajaDeAeronave(this.numero, this.fechaBaja.value, this.fechaReinicio.Value);
                }
                else {
                    DAO.DAOAeronave.bajaDeAeronave(this.numero, this.fechaBaja.value, Convert.ToDateTime(fechaDefault));
                }
                MessageBox.Show("Se dio de baja exitosamente la aeronave:" + this.matricula);
                this.LauncherBaja.reload();
            }
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

        public void setBajaAeronave(Decimal numero)
        {

            this.numero = numero;
        }

        private void MotivoBajaAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MotivoBajaAeronave.SelectedIndex == 1)
            {
                this.label2.Show();
                this.fechaReinicio.Show();
            }
            else
            {
                this.label2.Hide();
                this.fechaReinicio.Hide();
            }
        }


    }
}
