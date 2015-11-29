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

namespace AerolineaFrba.Compra
{
    public partial class Elegir_butacas : Form
    {
        public Elegir_Pasajeros launcher { get; set; }
        public Elegir_butacas()
        {
            InitializeComponent();
        }

        public Elegir_butacas(Elegir_Pasajeros launcher)
        {
            InitializeComponent();
            this.launcher = launcher;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Decimal butaca = Convert.ToDecimal(grid.cellValue("col_butaca"));
            String tipo =   grid.cellValue("col_tipo").ToString();
            launcher.setButacaCurrentRow(butaca,tipo);

            DAO.DAOAeronave.modificarEstadoButaca(launcher.viaje.codigo, butaca, 1);
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Elegir_butacas_Load(object sender, EventArgs e)
        {
            DAO.DAOAeronave.getButacasDisponibles(launcher.viaje, grid);
        }
    }
}
