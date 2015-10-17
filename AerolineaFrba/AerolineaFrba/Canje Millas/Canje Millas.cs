using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Canje_Millas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RealizarCanje_Click(object sender, EventArgs e)
        {
            try { validarCampos(); }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validarCampos()
        {

            var cantidad = "";
            var dni = "";
            var invalido = false;

            foreach (DataGridViewRow row in ProductosCanjear.Rows)
            {
                if (row == null)
                {
                    cantidad = "Inserte una cantidad";
                    invalido = true;
                }
            }
            if (DNI.Text == String.Empty)
            {
                dni = "Inserte un DNI";
                invalido = true;
            }
            if (invalido)
            throw new Exception(dni + cantidad);



        }
    }
}
