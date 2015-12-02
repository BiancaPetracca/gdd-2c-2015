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

namespace AerolineaFrba
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(List<Decimal> funcionalidades, Decimal rol)
        {
            InitializeComponent();
            this.funcionalidades = funcionalidades;
            this.rol = rol;

        }

        public List<Decimal> funcionalidades { get; set; }
        private Decimal rol {get; set;}  // 0 para admin, 1 para cliente, etc 

        /********* CADA PESTAÑA DEL MENU HACE LO MISMO, ABRIR ESE FORM EN EL ********/

        private void rolABM_Click(object sender, EventArgs e)
        {
           this.openIntoParent(new Abm_Rol.RolListado(rol), this);

        }

        private void aeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.openIntoParent(new Abm_Aeronave.Aeronave(), this);
       

        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.openIntoParent(new Abm_Ciudad.Ciudad(), this);
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openIntoParent(new Abm_Ruta.Ruta(), this);
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.openIntoParent(new Generacion_Viaje.Generar_Viaje(), this);
        }

        private void registroDeLlegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openIntoParent(new Registro_Llegada_Destino.RegistroLlegadaAeronave(), this);
        }

        private void pasajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.Compra compra = new Model.Compra();
            compra.menu = this;
            this.openIntoParent(new Compra.Compra(compra), this);
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openIntoParent(new Devolucion.Devolver(), this);
        }

        private void canjearMillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.openIntoParent(new Canje_Millas.Canje_Millas(), this);
        }

        private void consultarMillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.openIntoParent(new Consulta_Millas.Consultar_Millas(), this);
        }

        private void verListadoEstadísticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.openIntoParent(new Listado_Estadistico.Listado_Estadisticas(), this);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            
            this.openInNewWindow(new Login.Login());
            this.Hide();
        }
        /* el cliente no puede ver: rol, ruta, aeronave, generar viaje, registro llegada, cancelacion, canje*/

        private void MainMenu_Load(object sender, EventArgs e)
        {
            changeVisibilityItems(funcionalidades, false);
        }

        private void changeVisibilityItems(List<Decimal> criteria, Boolean value) {
            foreach (ToolStripMenuItem item in this.items.Items) { 
                    if (!criteria.Contains(Convert.ToInt16(item.Tag))){
                    item.Enabled = value;
                    }
            }
        }

        private void enableAll() {
            foreach (ToolStripMenuItem item in this.items.Items) {

                item.Enabled = true;
            }
        }

        public void reload() {
            enableAll();
            changeVisibilityItems(funcionalidades, false);
            salir.Enabled = true;
        }

        private void item_ciudades_Click(object sender, EventArgs e)
        {
            //this.openIntoParent(new Abm_Ciudad.Ciudad(), this);
        }

    }
}
