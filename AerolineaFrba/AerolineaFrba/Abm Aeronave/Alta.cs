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


        private void lugar_butacas_Click(object sender, EventArgs e)
        {
            new Butacas().Show();
        }



        public void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Aceptar_Click(object sender, EventArgs e)
        {
            this.validateNotNullForAll(this.Controls);
        }

        private void nombre_MouseDown(object sender, MouseEventArgs e)
        {
    
        }

      
        }
    }

