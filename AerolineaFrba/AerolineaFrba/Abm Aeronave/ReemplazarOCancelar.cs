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
        public ReemplazarOCancelar()
        {
            InitializeComponent();
        }

        private void CancelarViajes_Click(object sender, EventArgs e)
        {
            DAOAeronave.bajaDeAeronave(this.tipoDeBaja, 0, this.matricula, this.fechaReinicio);
            MessageBox.Show("Se dio de baja la aeronave: " + this.matricula);
            this.BajaLauncher.reload();
            this.Close();
            
        }
        private void ReasignarViajes_Click(object sender, EventArgs e)
        {
            if (DAO.DAOAeronave.existeAeronaveQueReemplace(this.matricula) == -1)
            {
                MessageBox.Show("No existe ninguna aeronave que pueda reemplazarla: Debe dar de alta a otra. \n Recuerde que debe ser del mismo tipo, fabricante y ofrecer el mismo servicio: \n"
                + this.matricula);
                
                this.openInNewWindow(new Abm_Aeronave.Alta());
                return;
            }
            DAOAeronave.bajaDeAeronave(this.tipoDeBaja, 1, this.matricula, this.fechaReinicio);
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
