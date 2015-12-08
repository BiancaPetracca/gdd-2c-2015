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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AdminModelos : Form
    {
        public AdminModelos()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new modificar(null, 1, this.Fabricante.value, this));
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (Fabricante.isValid())
            {
                this.openInNewWindow(new modificar(modelos.cellValue("col_modelo"), 0, Fabricante.value, this));
            }
        }

        private void Fabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reload();
        }

        public void reload()
        {
            DAO.DAOAeronave.getModelos(this.Fabricante.value, this.modelos);
        }

        private void AdminModelos_Load(object sender, EventArgs e)
        {
            this.Fabricante.AddAll(DAO.DAOAeronave.listarFabricantes());
        }
    }
}
