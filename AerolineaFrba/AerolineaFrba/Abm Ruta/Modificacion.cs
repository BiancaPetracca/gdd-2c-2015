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

        public Modificacion(Model.Ruta ruta, Abm_Ruta.Ruta launcher)
        {
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
            // validaciones de que no haya ningún campo vacio y de dominio (que no sean iguales las ciudades 
            if (!this.validateNotNullForAll(this.datosRuta.Controls)) { return; }
            if (!this.validateDomain(Validations.criteriumMessage(() => this.Origen.value != this.Destino.value, "No pueden ser iguales las ciudades"),
                 Validations.criteriumMessage(() => this.PrecioKG.valid() || this.PrecioPasaje.valid(), "No puede no tener precio para encomiendas ni para pasaje"))) { return; }


            // instancio la ruta modificada 
            Model.Ruta rutaModificada = new Model.Ruta(Convert.ToDecimal(this.Codigo.value), Origen.value, Destino.value, ruta.Habilitada, this.servicios.value, PrecioKG.value, PrecioPasaje.value);
            /* comparo la ruta vieja con la ruta modificada, si cambiaron cualquiera de sus ciudades no la puedo modificar si tiene
             * viajes asignados. para los servicios lo mismo. si cambiaron los precios, si tiene viajes asignados o si tiene pasajes
             * vendidos no me modifica en nada porque los precios aparecen en el pasaje y en las encomiendas, justamente para 
             * poder cambiarle un precio a esto sin que me afecte a lo demás. 
             */


            if (DAO.DAORuta.modificarRuta(ruta, rutaModificada) != -1)
            {
                MessageBox.Show("Ruta modificada con éxito!");
                launcher.reload();
                return;
            }
            MessageBox.Show("Ya existe una ruta con el mismo origen y destino que intenta ingresar");
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
            this.Origen.AddAll(Extensions.listToStr(DAO.DAOCompra.listCiudades(), "nombre"));
            this.Destino.AddAll(Extensions.listToStr(DAO.DAOCompra.listCiudades(), "nombre"));
            this.Codigo.Text = ruta.Codigo.ToString();
            this.Origen.SelectedItem = ruta.Origen;
            this.Destino.SelectedItem = ruta.Destino;
            this.servicios.check(ruta.Servicios);
            
            PrecioKG.ReadOnly = false;
            PrecioPasaje.ReadOnly = false;

            this.PrecioKG.Value = ruta.PrecioBaseKg;
            this.PrecioPasaje.Value = ruta.PrecioBasePasaje;

            if (DAO.DAORuta.tieneViajesAsignados(ruta.Codigo))
            {

                MessageBox.Show("La ruta tiene viajes asignados, solo puede modificar los precios.");
                this.enableAll(false, Origen, Destino, Codigo, servicios);
                return;

            }
            this.enableAll(true, Origen, Destino, Codigo, servicios);


        }

    }
}
