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
                butacasPasillo.value,
                butacasVentanilla.value, kgsEncomiendas.value, estado.value, servicio.value);
            if (this.validateNotNullForAll(this.Controls))
            {
                if (!Aeronave.Equals(AeronaveModificada)) // TODO QUE SE COMPARE BIEN
                {
                    //UPDATEAR SI SE MODIFICARON EN ALGO 
                    if (DAO.DAOAeronave.modificarAeronave(AeronaveModificada) == -1)
                    {
                        MessageBox.Show("La matrícula ya está siendo usada por otra aeronave. Elija otra.");
                        return;
                    }
                    MessageBox.Show("La aeronave fue actualizada con éxito.");
                    launcher.reload();
                    this.Close();
                    return;

                }
                MessageBox.Show("No actualizó ningún campo: la aeronave no se ha modificado.");
                this.Close();
            }

        }


        private void Modificacion_Load(object sender, EventArgs e)
        {
            this.modelo.Text = aeronave.modelo;
            this.matriculaLetras.Text = aeronave.matricula.Substring(0, 3);
            this.matriculaNumeros.Text = aeronave.matricula.Substring(4, 3);
            this.fabricante.Text = aeronave.fabricante;
            this.servicio.setItem(aeronave.servicio);
        //    this.estado.Checked = aeronave.estadoAeronave;
            this.kgsEncomiendas.Value = aeronave.kgsEncomiendas;
            this.butacasPasillo.Value = aeronave.cantidadButacasPasillo;
            this.butacasVentanilla.Value = aeronave.cantidadButacasVentanilla;

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


    }
}

