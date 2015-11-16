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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Modificacion : Form
    {
        private Model.Ruta ruta;
        private Abm_Ruta.Ruta launcher;

        public Modificacion(Model.Ruta ruta, Abm_Ruta.Ruta launcher) {
            InitializeComponent();
            this.ruta = ruta;
            this.launcher = launcher;
        }
        public Modificacion()
        {
            InitializeComponent();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (!this.validateNotNullForAll(this.datosRuta.Controls)) { return; }
            if (!this.validateDomain(Validations.criteriumMessage(() => this.Origen.value != this.Destino.value, "No pueden ser iguales las ciudades"),
                 Validations.criteriumMessage(() => this.PrecioKG.valid() || this.PrecioPasaje.valid(), "No puede no tener precio para encomiendas ni para pasaje"))) { return; }
            Model.Ruta rutaModificada = new Model.Ruta(Origen.value, Destino.value, ruta.Habilitada, servicio.value, PrecioKG.value, PrecioPasaje.value);

            if (DAO.DAORuta.modificarRuta(ruta.Codigo, rutaModificada) == 1) {
                MessageBox.Show("Ruta modificada con éxito.");
                launcher.reload();
                this.Close();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Servicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            this.Origen.AddAll(Extensions.listToStr(DAO.DAOCompra.listCiudades(), "nombre_ciudad"));
            this.Destino.AddAll(Extensions.listToStr(DAO.DAOCompra.listCiudades(), "nombre_ciudad"));
            this.Codigo.Text = ruta.Codigo.ToString();
            this.Origen.SelectedItem = ruta.Origen;
            this.Destino.SelectedItem = ruta.Destino;
            this.servicio.SelectedItem = ruta.Servicio;
            this.PrecioKG.Value = ruta.PrecioBaseKg;
            this.PrecioPasaje.Value = ruta.PrecioBasePasaje;
            
        }

  
    }
}
