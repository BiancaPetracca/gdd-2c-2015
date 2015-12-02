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
using AerolineaFrba.DAO;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Alta(this));
        }


        private void Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {

        }



        private void Ruta_Load(object sender, EventArgs e)
        {
            DAO.DAORuta.getRutas(this.lista);
            this.origen.AddAll(DAOCompra.listarCiudades());
            this.destino.AddAll(DAOCompra.listarCiudades());
        }

        public void reload() {
            DAO.DAORuta.getRutas(this.lista);
        }

        private void darDeBaja_Click(object sender, EventArgs e)
        {
            DAO.DAORuta.darDeBaja(this.getCurrentRuta());
            MessageBox.Show("Se dio de baja a la ruta");
            this.reload();

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Model.Ruta ruta = this.getCurrentRuta();
            // abro una form de modificacion y mando a este form para que pueda hacer un reload luego cuando modifica
            this.openInNewWindow(new Modificacion(ruta, this));

        }

        private Model.Ruta getCurrentRuta()
        {
            return new Model.Ruta(Convert.ToUInt16(Extensions.cellValue(this.lista, "col_codigo")),
                (String)Extensions.cellValue(this.lista, "col_origen"),
             (String)Extensions.cellValue(this.lista, "col_destino"),
             (Boolean)Extensions.cellValue(this.lista, "col_habilitada"),
             DAO.DAORuta.getServicios(Convert.ToInt16(Extensions.cellValue(this.lista, "col_codigo"))),
             Convert.ToDecimal(Extensions.cellValue(this.lista, "col_pb_kg")),
             Convert.ToDecimal(Extensions.cellValue(this.lista, "col_pb_pasaje")));
            

        }


        private void limpiar_Click_1(object sender, EventArgs e)
        {
            Extensions.cleanAll(this.filtros.Controls);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.reloadNew();
        }

        private void buscar_Enter(object sender, EventArgs e)
        {
            
        }

        private void reloadNew()
        {
            String o;
            String d;
            try
            {
                o = this.origen.value;
                d = this.destino.value;
            }
            catch
            {
                MessageBox.Show("Seleccione un origen y destino");
                return;
            }

            DAO.DAORuta.filtrarRutas(o, d, this.lista);
        }
    }
}