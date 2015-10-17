using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try { validarCampos(); }
            catch (Exception excepcion) {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {

        }

        private void validarCampos()
        {
            var codigo = "";
            var servicio = "";
            var ciudad = "";
            var precio = "";

            if (this.Codigo.Text == String.Empty)
            {
                codigo = "Inserte un código \n";
            }
            if (this.Servicio.CheckedItems.Count == 0)
            {
                servicio = "Elija un servicio \n";
            }
            if (this.Origen.SelectedIndex == -1 || this.Destino.SelectedIndex == -1)
            {
                ciudad = "Elija una ciudad \n";
            }
            if (this.PrecioPasaje.Value == 0 || this.PrecioKG.Value == 0)
            {
                precio = "Asigne un precio \n";
            }

            throw new Exception(codigo + servicio + ciudad + precio);

        }
    }
}
