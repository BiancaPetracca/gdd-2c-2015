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

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class Listado_Estadisticas : Form
    {
        public Listado_Estadisticas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Top5.Refresh();
            this.Close();
        }

        private void superNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private DateTime fechaInicio() {
            if (semestre.value.Equals("1"))
            {
                return Convert.ToDateTime(anio.value + "-01-01");
            }
                return Convert.ToDateTime(anio.value + "-07-01");
        }

        private DateTime fechaFin()
        {
            if (semestre.value.Equals("1"))
            {
                return Convert.ToDateTime(anio.value + "-06-30");
            }
            return Convert.ToDateTime(anio.value + "-12-31");
        }




        private void Listado_Estadisticas_Load(object sender, EventArgs e)
        {
            enableAll(false);
        }

        private void enableAll(Boolean val)
        {
            millasAcumuladas.Enabled = val;
            pasajesCancelados.Enabled = val;
            pasajesComprados.Enabled = val;
            aeronaves_vacias.Enabled = val;
            fueraServicio.Enabled = val;
        }

        private void millasAcumuladas_Click(object sender, EventArgs e)
        {
            Top5.Columns.Clear();
            DAO.DAOMillas.clientesConMasMillas(fechaInicio(), fechaFin(), Top5);
          
        }

        private void pasajesComprados_Click(object sender, EventArgs e)
        {
            Top5.Columns.Clear();
            DAO.DAOMillas.destinosConMasPasajesComprados(fechaInicio(), fechaFin(), Top5);
        }

        private void pasajesCancelados_Click(object sender, EventArgs e)
        {
            Top5.Columns.Clear();
            DAO.DAOMillas.destinosConMasPasajesCancelados(fechaInicio(), fechaFin(), Top5);
        }

        private void fueraServicio_Click(object sender, EventArgs e)
        {
            Top5.Columns.Clear();
            DAO.DAOMillas.AeronavesConMasVecesFueraDeServicio(fechaInicio(), fechaFin(), Top5);
        }

        private void aeronaves_vacias_Click(object sender, EventArgs e)
        {
            Top5.Columns.Clear();
            DAO.DAOMillas.destinosConMasAeronavesVacias(fechaInicio(), fechaFin(), Top5);
        }

        private void superButton1_Click(object sender, EventArgs e)
        {
            Top5.Columns.Clear();
        }

        private void semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semestre.SelectedIndex != -1 && anio.SelectedIndex != -1)
            {
                enableAll(true);
                return;
            }
            enableAll(false);
        }
        private void anio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semestre.SelectedIndex != -1 && anio.SelectedIndex != -1) {
            enableAll(true);
                return;
            }

            enableAll(false);
        }
    }
}
