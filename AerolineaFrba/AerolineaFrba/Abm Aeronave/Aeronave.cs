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
using AerolineaFrba.Model;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Aeronave : Form
    {
        private String filtro { get; set; }
        public Aeronave()
        {
            InitializeComponent();
        }

        // AGREGAR Y BORRAR ABRE LOS RESPECTIVOS FORMULARIOS
        private void Agregar_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Alta(this));
        }



        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Model.Aeronave aeronave = getCurrentAeronave();

            // abro una form de modificacion y mando a este form para que pueda hacer un reload luego cuando modifica
            this.openInNewWindow(new Modificacion(aeronave, this));

        }

        private Model.Aeronave getCurrentAeronave() {
           return new Model.Aeronave(DAO.DAOAeronave.obtenerCodigoAeronave((String)Extensions.cellValue(this.lista, "col_matricula")), 

            (String)Extensions.cellValue(this.lista, "col_modelo"),
            (String)Extensions.cellValue(this.lista, "col_matricula"),
            (String)Extensions.cellValue(this.lista, "col_fabricante"),

            Convert.ToDecimal(Extensions.cellValue(this.lista, "col_butacas_pasillo")),
            Convert.ToDecimal(Extensions.cellValue(this.lista, "col_butacas_vent")),

            Convert.ToDecimal(Extensions.cellValue(this.lista, "col_kgs")),
            (Boolean)Extensions.cellValue(this.lista, "col_estado"),
            (String)Extensions.cellValue(this.lista, "col_servicio"));
            
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
            Extensions.cleanAll(this.filtros.Controls);
            DAO.DAOAeronave.listarAeronaves(this.lista);
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
            DAO.DAOAeronave.listarAeronaves(this.lista);
        }

        // FILTRAR LAS AERONAVES SEGUN LO QUE HAYA SELECCIONADO EL USUARIO
        private void buscar_Click(object sender, EventArgs e)
        {
            this.reload();
        }

        private void HabilitadasFiltro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if ((Boolean)(this.lista.CurrentRow.Cells["col_estado"].Value))
            {
                Baja baja = new Baja();
                baja.LauncherBaja = this;
                String nombre_aeronave = this.lista.CurrentRow.Cells["col_matricula"].Value.ToString();
                baja.setBajaAeronave(nombre_aeronave);
                this.openInNewWindow(baja);
                return;
            }
            MessageBox.Show("La aeronave que intenta dar de baja ya se encuentra inhabilitada");
        }

        public void reload()
        {
            DAO.DAOAeronave.filtrarAeronaves(this.lista, this.HabilitadasFiltro.Checked, filtro);
        }

        private void ServicioFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtro = this.ServicioFiltro.SelectedIndex != -1 ? this.ServicioFiltro.SelectedItem.ToString() : null;
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }



    }
}
