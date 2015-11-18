using AerolineaFrba.DAO;
using AerolineaFrba.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistroLlegadaAeronave : Form
    {
        public RegistroLlegadaAeronave()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroLlegadaAeronave_Load(object sender, EventArgs e)
        {
            this.matricula.AddAll(DAO.DAOGenerarViaje.getAllAeronaves());
            this.AeropuertoOrigen.AddAll(DAO.DAOCompra.listarCiudades());
            this.AeropuertoDestino.AddAll(DAO.DAOCompra.listarCiudades());
        }

        private void Agregar_Click_1(object sender, EventArgs e)
        {// cuando agrego una aeronave al a data grid tengo que validar que tenia que llegar a ese lugar en esa fecha aproximada
            if (!this.validateNotNullForAll(this.aeronaveLlegada.Controls)) { return;  }
            Model.Viaje viaje = new Model.Viaje(this.matricula.value, this.AeropuertoOrigen.value, this.AeropuertoDestino.value, this.fechaLlegada.value);
            if (DAO.DAOGenerarViaje.aeronaveYaRegistrada(viaje) == 1)
            {
                MessageBox.Show("La aeronave que intenta registrar ya se registró previamente.");
                Extensions.cleanAll(this.aeronaveLlegada.Controls);
                return;
            }
            if (DAO.DAOGenerarViaje.coincideConElViaje(viaje) == 1){
                this.registros.Rows.Add(this.matricula.value, this.AeropuertoOrigen.value, this.AeropuertoDestino.value, this.fechaLlegada.value);
                Extensions.cleanAll(this.aeronaveLlegada.Controls);
                return;
            }
            MessageBox.Show("La aeronave no coincide con el viaje que ingresa, por favor verifique los datos.");
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.registros.Rows) {
               
                Model.Viaje viaje = new Model.Viaje((String)row.Cells["col_matricula"].Value,
                    (String)row.Cells["col_origen"].Value, (String)row.Cells["col_destino"].Value, Convert.ToDateTime(row.Cells["col_llegada"].Value));

                DAO.DAOGenerarViaje.agregarRegistroLlegada(viaje);
                
            }

            MessageBox.Show("Viajes registrados con éxito!");
            this.Close();
        }

     /*   private Model.Viaje getViajeIngresado() {
           return new Model.Viaje(new Model.Aeronave(this.matricula.value), 
                new Model.Ciudad(this.AeropuertoOrigen.value),
                new Model.Ciudad(this.AeropuertoDestino.value),
                this.fechaLlegada.value); */

             private Model.Viaje getViajeIngresado() {
           return new Model.Viaje(this.matricula.value,
               this.AeropuertoOrigen.value,
               this.AeropuertoDestino.value,
               this.fechaLlegada.value);
        }


    }
}
