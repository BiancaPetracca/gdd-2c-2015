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
    public partial class Efectuar_Compra : Form
    {
        public Efectuar_Compra()
        {
            InitializeComponent();
        }
        public Decimal CodigoCompra { get; set; }
        public Efectuar_Compra(Decimal CodigoCompra) {
            InitializeComponent();
            this.CodigoCompra = CodigoCompra;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MedioPago.ValueMember == "Efectivo")
            {
                this.openInNewWindow(new Exito_Efectivo());
                return;
            }
            
                this.openInNewWindow(new Exito_Tarjeta());
            }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Efectuar_Compra_Load(object sender, EventArgs e)
        {
            if (Config.Terminal == 1) {
                this.MedioPago.SelectedItem = "Tarjeta de Credito";
                this.MedioPago.Enabled = false;
            }
        }
    }
}
