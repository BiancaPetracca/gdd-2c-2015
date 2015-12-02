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
    public partial class Exito_Efectivo : Form
    {
        public Decimal codigo;
        public Efectuar_Compra launcher;
        public Exito_Efectivo(Decimal codigo, Efectuar_Compra launcher)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.launcher = launcher;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.launcher.Close();
            this.Close();
        }


        private void Exito_Efectivo_Load(object sender, EventArgs e)
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
