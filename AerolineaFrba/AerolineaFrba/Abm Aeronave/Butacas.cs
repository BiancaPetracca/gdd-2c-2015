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
    public partial class Butacas : Form
    {
        public Decimal CantidadButacas { get; set; }
        public Abm_Aeronave.Modificacion launcherM = new Modificacion();
        public Abm_Aeronave.Alta launcherA = new Alta();

        public Butacas()
        {
            InitializeComponent();
        }

      
        // ver: 0, alta: 1, modificacion: 2
        public Butacas(Abm_Aeronave.Modificacion launcherM, int avion, int motivo)
        {
            InitializeComponent();
            this.launcherM = launcherM;
            this.avion = avion;
            this.motivo = motivo;

        }

        public Butacas(int avion, int motivo)
        {
            InitializeComponent();
           
            this.avion = avion;
            this.motivo = motivo;

        }

        public Butacas(Abm_Aeronave.Alta launcherA, int motivo)
        {
            InitializeComponent();
            this.launcherA = launcherA;
            
            this.motivo = motivo;

        }
        public Boolean letEvents = false;
        public DataGridView copy_grid = new DataGridView();
        public int motivo { get; set; }
        public int avion { get; set; }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            if (!validate())
            {
                MessageBox.Show("Debe elegir los tipos de las butacas");
                return;
            }
            this.mandarDG_launcher();
            this.Close();



        }

        private Boolean validate()
        {
         
            Boolean valid = true;
            foreach (DataGridViewRow rw in this.grid.Rows)
            {
                if (rw.Cells["col_tipo"].Value == null && !rw.IsNewRow)
                {
                    valid = false;
                    return valid;
                }
             }
            return valid;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Butacas_Load(object sender, EventArgs e)
        {
            if (this.motivo != 0) { this.allowUserToModifyRows(); }
            if (this.motivo != 2) { this.letEvents = true; }
            if (this.motivo != 1)
            {
                DAO.DAOAeronave.getButacas(avion, this.grid);
                this.letEvents = true;
                this.copy_grid = this.grid;
            }

        }

        private void allowUserToModifyRows()
        {
            this.grid.AllowUserToAddRows = true;
            this.grid.AllowUserToDeleteRows = true;
            this.grid.Columns["col_tipo"].ReadOnly = false;

        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            reasignar_butacas();
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            reasignar_butacas();
        }

        private void reasignar_butacas()
        {
            if (this.motivo != 0 && this.letEvents)
            {
                foreach (DataGridViewRow row in this.grid.Rows)
                {
                        row.Cells["col_butaca"].Value = row.Index;
                  
                }
            }

        }

        private void mandarDG_launcher() {
            if (this.motivo == 1) {
                launcherA.setButacasNuevas(this.grid);
            }
            if (this.motivo == 2) {
                launcherM.setButacasModificadas(this.grid);
            }
        }
    }
}
