﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Alta alta = new Alta();
            alta.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Modificacion modificacion = new Modificacion();
            modificacion.Show();

        }


    }
}
