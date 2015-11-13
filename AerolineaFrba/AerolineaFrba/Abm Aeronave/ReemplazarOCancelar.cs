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
            if (this.tipoDeBaja == 1)
            {
                SqlConnector.executeProcedure("bajaLogicaDeAeronavePorFinDeVidaUtil", this.matricula, 0);
                return;
            }
            SqlConnector.executeProcedure("bajaLogicaDeAeronavePorMantenimiento", this.matricula, this.fechaReinicio, 0);
        }

        private void ReasignarViajes_Click(object sender, EventArgs e)
        {
            SqlConnector.executeProcedure("reemplazoDeAeronaveEnViajes");
        }

        public void setTipoDeBaja(int tipo, String matricula, DateTime fechaBaja, String fechaReinicio) {
            this.tipoDeBaja = tipo;
            this.matricula = matricula;
            this.fechaBaja = fechaBaja;
            this.fechaReinicio = fechaReinicio;
        }
    }
}
