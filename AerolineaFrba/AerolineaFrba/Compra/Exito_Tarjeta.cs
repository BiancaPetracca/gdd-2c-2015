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
    public partial class Exito_Tarjeta : Form
    {
        public Decimal codigo { get; set; }
        public Efectuar_Compra launcher { get; set; }
        public Exito_Tarjeta(Decimal codigo, Efectuar_Compra launcher)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.launcher = launcher;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.launcher.Close();
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 

        private void Exito_Tarjeta_Load(object sender, EventArgs e)
        {
            this.pnr.Text = Convert.ToString(codigo);
        }

        private void detalleEncomienda_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Detalle_Compra(codigo, "Encomiendas", launcher));
        }

        private void detallePasajes_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Detalle_Compra(codigo, "Pasajes", launcher));
        }

        private void detalleCompra_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Detalle_Compra(codigo, "Compra", launcher));
        }
    }
}
