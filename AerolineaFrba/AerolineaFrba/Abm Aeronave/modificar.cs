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
    public partial class modificar : Form
    {
        public Abm_Aeronave.AdminModelos launcher { get; set; }
        public String viejoNombre { get; set; }
        public int ModificarOAgregar { get; set; }
        public String Fabricante { get; set; }
        public modificar()
        {
            InitializeComponent();
        }

        public modificar(String viejoNombre, int ModificarOAgregar, String Fabricante, Abm_Aeronave.AdminModelos launcher)
        {
            InitializeComponent();
            this.ModificarOAgregar = ModificarOAgregar;
            this.Fabricante = Fabricante;
            this.launcher = launcher;
            if (ModificarOAgregar == 0)
            {

                this.viejoNombre = viejoNombre;
            }

        }

        private void modificar_Load(object sender, EventArgs e)
        {
            if (ModificarOAgregar == 0)
            {
                this.nuevoNombre.Text = this.viejoNombre;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (ModificarOAgregar == 0) {
                if (String.Equals(this.viejoNombre,this.nuevoNombre)) { MessageBox.Show("Elija un nombre distinto al que quiere modificar!"); return;}
                if (DAO.DAOAeronave.modificarModelo(this.viejoNombre, this.nuevoNombre.value, this.Fabricante) == -1) {
                    MessageBox.Show("Ya existe ese nombre, elija otro");
                    return;
                }
                
            }
            if (DAO.DAOAeronave.agregarModelo(this.nuevoNombre.value, this.Fabricante) == -1) {
                MessageBox.Show("Ya existe ese nombre, elija otro");
                return;
            }
            launcher.reload();
            this.Close();

        }
    }
}
