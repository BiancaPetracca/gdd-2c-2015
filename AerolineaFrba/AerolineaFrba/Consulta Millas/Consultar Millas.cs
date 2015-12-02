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

namespace AerolineaFrba.Consulta_Millas
{
    public partial class Consultar_Millas : Form
    {
        public Consultar_Millas()
        {
            InitializeComponent();
        }

        private void Consultar_Millas_Load(object sender, EventArgs e)
        {

        }

        private void dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            if (tipo.valid() && dni.valid()) {
                DAO.DAOMillas.getMillasCanjes(canjes, tipo.value, dni.value);
                DAO.DAOMillas.getMillasPasajes(pasajes, tipo.value, dni.value);
                DAO.DAOMillas.getMillasEncomiendas(encomiendas, tipo.value, dni.value);
                return;
            }

            MessageBox.Show("Por favor, ingrese su tipo y número de documento");
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {

            canjes.clearBindedDT();
            encomiendas.clearBindedDT();
            pasajes.clearBindedDT();
            dni.clean();
            tipo.SelectedIndex = -1;
        }

        

       
    }
}
