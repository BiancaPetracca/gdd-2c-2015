using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Generics;
using AerolineaFrba.DAO;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class Generar_Viaje : Form
    {

        public Generar_Viaje()
        {
            InitializeComponent();
            this.fechaSalida.MinDate = Config.DateToday;
            this.fechaLlegadaEstimada.MinDate = Config.DateToday;
        }

        private void fechaLlegadaEstimada_ValueChanged(object sender, EventArgs e)
        {
            this.NombreAeronave.Items.Clear();
        }


        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (this.validateNotNullForAll(this.viaje.Controls) && !rutas.anyEmptyCells())
            {
                if (DAO.DAOGenerarViaje.generarViaje(this.NombreAeronave.value, 
                    this.fechaLlegadaEstimada.value,
                    this.fechaSalida.value,
                    this.rutas.CurrentRow.Cells[0].Value.ToString()) == -1) {
                    MessageBox.Show("Todos los campos son iguales, no puede ingresar un viaje repetido.");
                    return;
                }
                MessageBox.Show("Viaje generado con éxito!");
                reload();
                
            }
            
           
        }



        private Boolean tardaMenosDe24HsEnLlegar()
        {


            TimeSpan tiempoEnLlegarEstimado = (this.fechaSalida.Value).Subtract(this.fechaLlegadaEstimada.Value);

            return (Math.Abs(tiempoEnLlegarEstimado.TotalHours) <= 24);

        }

        private void Generar_Viaje_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload() {
            Extensions.cleanAll(viaje.Controls);
            rutas.clean();
         this.Origen.AddAll(Extensions.listToStr(DAOCompra.listCiudades(), "nombre"));
         this.Destino.AddAll(Extensions.listToStr(DAOCompra.listCiudades(), "nombre"));
        
        }

        private void fechaSalida_ValueChanged(object sender, EventArgs e)
        {
            this.fechaLlegadaEstimada.MinDate = this.fechaSalida.Value;
            this.NombreAeronave.Items.Clear();
        }

        private void BuscarAeronaves_Click(object sender, EventArgs e)
        {
            bool eqlDates = this.fechaSalida.Value.ToString() == this.fechaLlegadaEstimada.Value.ToString();
            bool tmspan = tardaMenosDe24HsEnLlegar();

            bool valid = this.validateDomain(Validations.criteriumMessage(() => !eqlDates, "Las fechas no pueden ser iguales"),
            Validations.criteriumMessage(() => tmspan, "No puede tardar mas de 24 hs en llegar"), Validations.criteriumMessage(() => Destino.value != Origen.value, "Ciudad origen y destino no pueden ser iguales"));
            if (valid)
            {
                if (DAO.DAOGenerarViaje.getRutas(Origen.value, Destino.value, fechaSalida.value, fechaLlegadaEstimada.value, rutas) == -1) {

                    MessageBox.Show("No hay rutas con este recorrido");
                 
                    return;
                }

                this.NombreAeronave.AddAll(DAO.DAOGenerarViaje.getAeronavesCompatibles(Convert.ToDecimal(rutas.Rows[0].Cells["col_codigo"].Value), fechaSalida.value, fechaLlegadaEstimada.value));

                if (this.NombreAeronave.Items.Count == 0)
                {
                    MessageBox.Show("No hay aeronaves disponibles en esas fechas, con ese recorrido y los servicios que ofrece el mismo");
                    rutas.Refresh();
                    return;
                }

             
            }
        }


    }
}
