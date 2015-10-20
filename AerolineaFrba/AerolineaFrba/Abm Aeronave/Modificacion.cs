using System;
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
    public partial class Modificacion : TemplateForm
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void fabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lugar_butacas_Click(object sender, EventArgs e)
        {
            new Butacas().Show();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
validateAll(this.Controls);
        }
    }
    }

