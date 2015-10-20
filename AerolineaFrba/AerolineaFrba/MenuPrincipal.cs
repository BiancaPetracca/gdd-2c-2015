using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.ABM_Templates;

namespace AerolineaFrba
{
    public partial class Inicio : TemplateForm
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void rolABM_Click(object sender, EventArgs e)
        {
            openIntoParent(new Abm_Rol.RolListado(), this);

        }

        private void aeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openIntoParent(new Abm_Aeronave.Aeronave(), this);
       

        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openIntoParent(new Abm_Ciudad.Ciudad(), this);
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openIntoParent(new Abm_Ruta.Ruta(), this);
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openIntoParent(new Generacion_Viaje.Form1(), this);
        }

        private void registroDeLlegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Registro_Llegada_Destino.Form1().Show();
        }

        private void pasajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openIntoParent(new Compra.Compra(), this);
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openIntoParent(new Devolucion.Devolver(), this);
        }

        private void canjearMillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           openIntoParent(new Canje_Millas.Form1(), this);
        }

        private void consultarMillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           openIntoParent(new Consulta_Millas.Form1(), this);
        }

        private void verListadoEstadísticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           openIntoParent(new Listado_Estadistico.Form1(), this);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openIntoParent(new AerolineaFrba.SuperControls.pruebasupers(), this);
        }

       

    }
}
