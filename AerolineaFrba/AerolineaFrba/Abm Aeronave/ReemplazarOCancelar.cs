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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ReemplazarOCancelar : Form
    {
        public ReemplazarOCancelar()
        {
            InitializeComponent();
        }

        private void CancelarViajes_Click(object sender, EventArgs e)
        {
            DAOAeronave.darDeBajaAeronave(this.tipoDeBaja, this.matricula, this.fechaReinicio);
            MessageBox.Show("Se dio de baja la aeronave: " + this.matricula);
            this.Close();
            
        }
        private void ReasignarViajes_Click(object sender, EventArgs e)
        {
            SqlConnector.executeProcedure("reemplazoDeAeronaveEnViajes");
        }

        public void setTipoDeBaja(int tipo, String matricula, DateTime fechaBaja, DateTime fechaReinicio) {
            this.tipoDeBaja = tipo;
            this.matricula = matricula;
            this.fechaBaja = fechaBaja;
            this.fechaReinicio = fechaReinicio;
        }
    }
}
