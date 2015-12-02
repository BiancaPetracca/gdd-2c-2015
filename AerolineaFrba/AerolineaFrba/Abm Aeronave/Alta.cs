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
using AerolineaFrba.SuperControls;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Alta : Form
    {
        
        private Abm_Aeronave.Aeronave launcher { get; set; }
        private Model.Aeronave aeronave { get; set; }
        public Abm_Aeronave.Aeronave Launcher { get { return launcher; } set { launcher = value; } }
        public Model.Aeronave Aeronave { get { return aeronave; } set { aeronave = value; } }
        public Boolean butacasElegidas { get; set; }
        public DataGridView dgButacas { get; set; }

        public Alta()
        {
            InitializeComponent();
        }

        public Alta(Abm_Aeronave.Aeronave launcher)
        {

            InitializeComponent();
            this.launcher = launcher;
            this.butacasElegidas = false;

        }

        private void fabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Load(object sender, EventArgs e)
        {
            this.fabricante.AddAll(DAO.DAOAeronave.listarFabricantes());
        }


        private void lugar_butacas_Click(object sender, EventArgs e)
        {
            new Butacas().Show();
        }



        public void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // QUE NO HAYAN CAMPOS NULOS
        public void Aceptar_Click(object sender, EventArgs e)
        {
            if (this.validateNotNullForAll(this.Controls))
            {
                Aeronave = new Model.Aeronave(0,
                     modelo.value, matriculaLetras.value + "-" + matriculaNumeros.value, fabricante.value,
                     kgsEncomiendas.value, true, servicio.value);
                
                if (DAO.DAOAeronave.altaDeAeronave(Aeronave, dgButacas) == -1)
                {
                    MessageBox.Show("No se pudo insertar la aeronave, ingrese otra matrícula diferente");
                    return;
                }
                MessageBox.Show("Éxito en el alta de aeronave.");
                Launcher.reload();
                this.Close();


            }
        }

        private void nombre_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void matriculaLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphaOnly(e);
        }

        private void matriculaNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
        }

        private void fabricante_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphaOnly(e);
        }

        private void modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphaOnly(e);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kgsEncomiendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowLessThanLength(this.kgsEncomiendas, e);
        }



        private void fabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modelo.clean();
            this.modelo.AddAll(DAO.DAOAeronave.listarModelos(this.fabricante.value));
        }

        private void elegirButacas_Click(object sender, EventArgs e)
        {
            Butacas but = new Abm_Aeronave.Butacas(this, 1);
          
            this.openInNewWindow(but);
        }



        public void setButacasNuevas(DataGridView dg)
        {
            this.dgButacas = dg;
        }
    }


}


