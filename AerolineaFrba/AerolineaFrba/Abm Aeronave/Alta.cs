﻿using System;
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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void fabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.validarCampos();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            this.Close();
        }

        private void lugar_butacas_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Butacas butacas = new Butacas();
            butacas.Show();
        }

        private void validarCampos()
        {

            var nombreInvalido = "";
            var fabricanteInvalido = "";

            if (nombre.Text == String.Empty)
            {
                nombreInvalido = "Inserte un nombre \n";
            }
            if (fabricante.Text == String.Empty)
            {
                fabricanteInvalido = "Inserte un fabricante";
            }

                throw new Exception(nombreInvalido + fabricanteInvalido);
            }

        }
    }

