using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaSaldo_Click(object sender, EventArgs e)
        {

        }

        private void operacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolABM_Click(object sender, EventArgs e)
        {
            Abm_Rol.RolListado a = new Abm_Rol.RolListado();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.WindowState = FormWindowState.Maximized;
            a.Show();

        }

        private void aeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Aeronave aeronave = new Abm_Aeronave.Aeronave();
            aeronave.MdiParent = this;
            aeronave.Dock = DockStyle.Fill;
        //    aeronave.WindowState = FormWindowState.Normal;
            aeronave.Show();

        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Ciudad.Ciudad ciudad = new Abm_Ciudad.Ciudad();
            ciudad.MdiParent = this;
            ciudad.Dock = DockStyle.Fill;
            ciudad.WindowState = FormWindowState.Maximized;
            ciudad.Show();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Ruta.Ruta ruta = new Abm_Ruta.Ruta();
            ruta.MdiParent = this;
            ruta.Dock = DockStyle.Fill;
            ruta.WindowState = FormWindowState.Maximized;
            ruta.Show();
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generacion_Viaje.Form1 viaje = new Generacion_Viaje.Form1();
            viaje.MdiParent = this;
            viaje.Dock = DockStyle.Fill;
            viaje.WindowState = FormWindowState.Maximized;
            viaje.Show();
        }

        private void registroDeLlegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Llegada_Destino.Form1 registroLlegada = new Registro_Llegada_Destino.Form1();
            registroLlegada.Show();
        }

        private void pasajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra.Compra comprar = new Compra.Compra();
            comprar.MdiParent = this;
            comprar.Dock = DockStyle.Fill;
            comprar.WindowState = FormWindowState.Maximized;
            comprar.Show();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucion.Devolver devolucion = new Devolucion.Devolver();
            devolucion.MdiParent = this;
            devolucion.Dock = DockStyle.Fill;
            devolucion.WindowState = FormWindowState.Maximized;
            devolucion.Show();
        }

        private void canjearMillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canje_Millas.Form1 canjear = new Canje_Millas.Form1();
           canjear.MdiParent = this;
            canjear.Dock = DockStyle.Fill;
            canjear.WindowState = FormWindowState.Maximized;
            canjear.Show();
        }

        private void consultarMillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Millas.Form1 consultar = new Consulta_Millas.Form1();
            consultar.MdiParent = this;
            consultar.Dock = DockStyle.Fill;
            consultar.WindowState = FormWindowState.Maximized;
            consultar.Show();
        }

        private void verListadoEstadísticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.Form1 listado = new Listado_Estadistico.Form1();
            listado.MdiParent = this;
            listado.Dock = DockStyle.Fill;
            listado.WindowState = FormWindowState.Maximized;
            listado.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
