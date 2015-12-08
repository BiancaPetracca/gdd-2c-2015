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
    public partial class Modificacion : Form
    {
        public DataGridView butacasModificadas = new DataGridView();
        private Model.Aeronave aeronave { get; set; }
        public Model.Aeronave Aeronave { get { return aeronave; } set { aeronave = value; } }
        public Model.Aeronave AeronaveModificada { get; set; }
        private Model.Aeronave aeronaveModificada { get { return aeronaveModificada; } set { aeronaveModificada = value; } }
        private Abm_Aeronave.Aeronave launcher { get; set; }
        public Modificacion()
        {
            InitializeComponent();
        }

        public Modificacion(Model.Aeronave aeronave, Abm_Aeronave.Aeronave launcher)
        {
            InitializeComponent();
            this.Aeronave = aeronave;
            this.launcher = launcher;
        }

        private void fabricante_TextChanged(object sender, EventArgs e)
        {

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
            AeronaveModificada = new Model.Aeronave(this.Aeronave.numero,
                modelo.value, matriculaLetras.value+"-"+matriculaNumeros.value, fabricante.value,
      kgsEncomiendas.value, servicio.value);
            if (this.validateNotNullForAll(this.Controls))
            {
                if (!Aeronave.Equals(AeronaveModificada)) // TODO QUE SE COMPARE BIEN
                {
                    //UPDATEAR SI SE MODIFICARON EN ALGO 
                    if (DAO.DAOAeronave.modificarAeronave(AeronaveModificada, butacasModificadas) == -1)
                    {
                        MessageBox.Show("La matrícula ya está siendo usada por otra aeronave. Elija otra.");
                        return;
                    }
                    MessageBox.Show("La aeronave fue actualizada con éxito.");

                    launcher.listarAeronaves();
                    this.Close();
                    return;

                }
                MessageBox.Show("No actualizó ningún campo: la aeronave no se ha modificado.");
                this.Close();
            }

        }


        private void Modificacion_Load(object sender, EventArgs e)
        
        {
            this.fabricante.AddAll(DAO.DAOAeronave.listarFabricantes());
            this.fabricante.SelectedItem = aeronave.fabricante;
            this.modelo.AddAll(DAO.DAOAeronave.listarModelos(this.fabricante.value));
            this.modelo.SelectedItem = aeronave.modelo;
            this.matriculaLetras.Text = aeronave.matricula.Substring(0, 3);
            this.matriculaNumeros.Text = aeronave.matricula.Substring(4, 3);
            this.servicio.setItem(aeronave.servicio);
       
            this.kgsEncomiendas.Value = aeronave.kgsEncomiendas;
            if (DAO.DAOAeronave.tieneViajesAsignados(Aeronave.numero) == 1) {
                MessageBox.Show("La aeronave tiene viajes asignados, por lo tanto sólo puede cambiar la matrícula");
                this.fabricante.Enabled = false;
                this.modelo.Enabled = false;
                this.servicio.Enabled = false;
                this.elegirButacas.Enabled = false;
                this.kgsEncomiendas.ReadOnly = true;
             
            };
         

        }

        private void modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
        }

        private void fabricante_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphaOnly(e);
        }

        private void matriculaLetras_TextChanged(object sender, EventArgs e)
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


        private void fabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modelo.clean();
            this.modelo.AddAll(DAO.DAOAeronave.listarModelos(fabricante.value));
        }

        private void elegirButacas_Click(object sender, EventArgs e)
        {
            Aeronave.numero = DAO.DAOAeronave.getNumeroAeronave(Aeronave.matricula);
            this.openInNewWindow(new Butacas(this, Aeronave.numero, 2));
        }

        public void setButacasModificadas(DataGridView dg)
        {
            this.butacasModificadas = dg;
        }
    }
}

