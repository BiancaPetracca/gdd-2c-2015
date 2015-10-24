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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.validateNotNullForAll(this.Controls);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
