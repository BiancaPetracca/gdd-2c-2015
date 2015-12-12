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

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class PosiblesLlegadas : Form
    {
        public Model.Viaje viaje { get; set; }
        public Registro_Llegada_Destino.RegistroLlegadaAeronave launcher { get; set; }
        public PosiblesLlegadas()
        {
            InitializeComponent();
        }

        public PosiblesLlegadas(Model.Viaje viaje, Registro_Llegada_Destino.RegistroLlegadaAeronave launcher) {

            InitializeComponent();
            this.viaje = viaje;
            this.launcher = launcher;
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            Model.Viaje viajeARegistrar = new Model.Viaje();
            viajeARegistrar.codigo = Convert.ToDecimal(registros.cellValue("col_codigo"));
            viajeARegistrar.matricula = registros.cellValue("col_matricula");
            viajeARegistrar.ciudadOrigen = registros.cellValue("col_origen");
            viajeARegistrar.ciudadDestino = registros.cellValue("col_destino");
            launcher.agregarViaje(viajeARegistrar);
            this.Close();
        }

        private void PosiblesLlegadas_Load(object sender, EventArgs e)
        {
            DAO.DAOGenerarViaje.getPosiblesLlegadas(viaje, registros);
            borrarYaRegistradas();
            if (registros.RowCount == 0) { MessageBox.Show("Ya no hay más viajes que registrar en esa fecha. Puede que ya los haya agregado a la lista."); this.Close(); }
        }

        private void borrarYaRegistradas() {
            for (int i = 0; i < registros.RowCount; i++) {
                if (launcher.tieneViaje(Convert.ToString(registros.Rows[i].Cells["col_codigo"].Value))) {
                    registros.Rows.RemoveAt(i);
                
                }
            
            }
        
        }
    }
}
