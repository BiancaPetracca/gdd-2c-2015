﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class Exito_Tarjeta : Form
    {
        public Exito_Tarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Detalle_Compra detalle = new Detalle_Compra();
            detalle.MdiParent = this.MdiParent;
            detalle.Dock = DockStyle.Fill;
            detalle.WindowState = FormWindowState.Maximized;
            detalle.Show();
       
        }
    }
}
