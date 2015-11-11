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
using AerolineaFrba.SuperControls;
using AerolineaFrba.DAO;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Aeronave : Form
    {
        public Aeronave()
        {
            InitializeComponent();
        }

        // AGREGAR Y BORRAR ABRE LOS RESPECTIVOS FORMULARIOS
        private void Agregar_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Alta());
        }
      

        private void Borrar_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Abm_Aeronave.Alta());

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Modificacion());
        }

        // VER BUTACAS
        private void VerButacas_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Butacas());
        }
        // NO PERMITIR QUE INSERTEN CARACTERES QUE NO SE PUEDEN
        private void MatriculaFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
           this.allowNumericOnly(e);
        }

        private void FabricanteFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphaOnly(e);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {

        }

        private void FabricanteFiltro_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }
        // LISTAR LAS AERONAVES
        private void Aeronave_Load(object sender, EventArgs e)
        {
            DAO.DAOAeronave.listarAeronaves(); 
        }

    }
}
