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
        // muestra el detalle de la compra
        private void button2_Click(object sender, EventArgs e)
        {

            this.openIntoParent(new Detalle_Compra(), this);
       
        }
    }
}
