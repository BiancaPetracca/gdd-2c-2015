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
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void Baja_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // para la fecha de reinicio
        {
            System.Windows.Forms.MonthCalendar calendar = new MonthCalendar();
            calendar.Show();
        }

        private void button1_Click(object sender, EventArgs e)  // para la fecha de baja
        {
            System.Windows.Forms.MonthCalendar calendar = new MonthCalendar();
            calendar.Show();
        }
    }
}