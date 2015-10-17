using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ciudad.Text == String.Empty)
                {
                   throw new Exception("Por favor, inserte un nombre");
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
