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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            this.validateNotNullForAll(this.Controls); 
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Servicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  
    }
}
