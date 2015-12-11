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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private Abm_Ruta.Ruta launcher;

        public Alta(Abm_Ruta.Ruta launcher)
        {
            InitializeComponent();
            this.launcher = launcher;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!this.validateNotNullForAll(this.datosRuta.Controls)) { return; }
            if (!this.validateDomain(Validations.criteriumMessage(() => this.Origen.value != this.Destino.value, "No pueden ser iguales las ciudades"),
                 Validations.criteriumMessage(() => this.PrecioKG.valid() || this.PrecioPasaje.valid(), "No puede no tener precio para encomiendas ni para pasaje"))) { return; }

            Model.Ruta ruta = getRutaIngresada();
            if (DAO.DAORuta.darDeAlta(ruta) != -1)
            {
                MessageBox.Show("Ruta creada con éxito!");
                Extensions.cleanAll(this.Controls);
                launcher.reload();
                return;
            }
            MessageBox.Show("Ya existe una ruta con el mismo origen y destino. Si lo que desea es quitarle o agregarle un servicio, abra la pestaña modificación.");

        }

        private void Alta_Load(object sender, EventArgs e)
        {
            PrecioKG.ReadOnly = false;
            PrecioPasaje.ReadOnly = false;
            Origen.AddAll(Extensions.listToStr(DAO.DAOCompra.listCiudades(), "nombre"));
            Destino.AddAll(Extensions.listToStr(DAO.DAOCompra.listCiudades(), "nombre"));
        }

        private Model.Ruta getRutaIngresada()
        {
            return new Model.Ruta(this.Origen.value, this.Destino.value, true, this.servicios.value, this.PrecioKG.value, this.PrecioPasaje.value);

        }

    }
}
