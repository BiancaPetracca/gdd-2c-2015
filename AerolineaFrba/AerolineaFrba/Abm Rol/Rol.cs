using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class RolForm : Form
    {
        public RolForm()
        {
            InitializeComponent();
        }

        private void Rol_Load(object sender, EventArgs e)
        {

        }

        private void filtro1_TextChanged(object sender, EventArgs e)
        {

        }



        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }


        private void bAlta_Click(object sender, EventArgs e)
        {
            Abm_Rol.Alta balta = new Abm_Rol.Alta();
            balta.Show();
        }

        private void bBaja_Click(object sender, EventArgs e)
        {
            Abm_Rol.Baja bbaja = new Abm_Rol.Baja();
            bbaja.Show();

        }
        
        private void bModificacion_Click(object sender, EventArgs e)
        {
            Abm_Rol.Modificacion bmod = new Abm_Rol.Modificacion();
            bmod.Show();
        }
    }
}
