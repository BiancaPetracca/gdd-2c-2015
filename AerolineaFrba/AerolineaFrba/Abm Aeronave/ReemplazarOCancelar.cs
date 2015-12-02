using AerolineaFrba.DAO;
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
    public partial class ReemplazarOCancelar : Form
    {
        private Abm_Aeronave.Aeronave bajaLauncher { get; set; }
        public Abm_Aeronave.Aeronave BajaLauncher { get { return bajaLauncher; } set { bajaLauncher = value; } }
        public Decimal numero;
        public ReemplazarOCancelar(Decimal numero)
        {
            InitializeComponent();
            this.numero = numero;
        }

        private void CancelarViajes_Click(object sender, EventArgs e)
        {

            if (tipoDeBaja == 0)
            {// fecha default para no mandarle null a la base de datos
                String fechaDefault = "01/01/1800 12:00:00";
                DAOAeronave.cancelarViajesAeronave(numero, fechaBaja,Convert.ToDateTime(fechaDefault));
            }
            else
            {
                DAOAeronave.cancelarViajesAeronave(numero, fechaBaja, fechaReinicio);
            }
            MessageBox.Show("Se dio de baja la aeronave: " + this.matricula);
            this.BajaLauncher.reload();
            this.Close();
            
        }
        private void ReasignarViajes_Click(object sender, EventArgs e)
        {
            String fechaDefault = "01/01/1800 12:00:00";
            int reemplazo;
               if (tipoDeBaja == 0) {
              reemplazo =  DAOAeronave.reemplazarViajes(numero, fechaBaja, Convert.ToDateTime(fechaDefault));
            }
               else {
             reemplazo = DAO.DAOAeronave.reemplazarViajes(numero, fechaBaja, fechaReinicio);
               }
            if(reemplazo == -1){
                MessageBox.Show("No existe ninguna aeronave que pueda reemplazarla: Debe dar de alta a otra. \n Recuerde que debe ser del mismo modelo, fabricante y ofrecer el mismo servicio: \n"
                + this.matricula);
                
                this.openInNewWindow(new Abm_Aeronave.Alta());
                return;
            }  
            this.BajaLauncher.reload();
            MessageBox.Show("Se reasignaron los viajes correctamente");
        }

        public void setTipoDeBaja(int tipo, String matricula, DateTime fechaBaja, DateTime fechaReinicio) {
            this.tipoDeBaja = tipo;
            this.matricula = matricula;
            this.fechaBaja = fechaBaja;
            this.fechaReinicio = fechaReinicio;
        }

    }
}
