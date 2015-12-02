using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class Detalle_Compra : Form
    {
        public Decimal codigo { get; set; }
        public String detalle { get; set; }
        public Efectuar_Compra launcher { get; set; }
        public Detalle_Compra(Decimal codigo, String detalle, Efectuar_Compra launcher)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.detalle = detalle;
            this.launcher = launcher;
        }

        private void Detalle_Compra_Load(object sender, EventArgs e)
        {
            if (detalle == "Encomiendas"){
            DAO.DAOCompra.getEncomiendas(codigo, compra);
            return;
        }
            if (detalle == "Pasajes")
            {
                DAO.DAOCompra.getPasajes(codigo, compra);
                return;
            }
            DAO.DAOCompra.getCompra(codigo, compra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void compra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
