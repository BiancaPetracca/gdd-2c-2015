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
    public partial class Canje_Millas : TemplateForm
    {
        public Canje_Millas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RealizarCanje_Click(object sender, EventArgs e)
        {
            validateAll(this.DatosCanjeador.Controls);

            try { if (this.ProductosCanjear.Rows.Count == 0) { throw new Exception("Elija algún producto para canjear"); } }
            catch (Exception excepcion) {
                MessageBox.Show(excepcion.Message);
            }
            
         
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
            validateAll(this.AgregarProductos.Controls);
        }

    }
}
