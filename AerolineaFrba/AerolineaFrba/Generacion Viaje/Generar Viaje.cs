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
            if (rutas.anyEmptyCells()) {MessageBox.Show("Debe tener un viaje armado"); return; }
            if (NombreAeronave.value == null) { MessageBox.Show("Ingrese una aeronave"); return; }
                if (DAO.DAOGenerarViaje.generarViaje(this.NombreAeronave.value, 
                    this.fechaLlegadaEstimada.value,
                    this.fechaSalida.value,
                    this.rutas.CurrentRow.Cells[0].Value.ToString()) == -1) {
                    MessageBox.Show("El viaje ya existe");
                    return;
                }
                MessageBox.Show("Viaje generado con éxito!");
                reload();
                
            
            
           
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
            NombreAeronave.clean();
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
            if (!this.validateNotNullForAll(viaje.Controls)) { return; }
            bool valid = this.validateDomain(Validations.criteriumMessage(() => !eqlDates, "Las fechas no pueden ser iguales"),
            Validations.criteriumMessage(() => tmspan, "No puede tardar mas de 24 hs en llegar"), Validations.criteriumMessage(() => Destino.value != Origen.value, "Ciudad origen y destino no pueden ser iguales"));
            if (valid)
            {
                if (!DAO.DAOGenerarViaje.hayRutas(Origen.value, Destino.value))
                {
                    MessageBox.Show("No hay rutas con ese recorrido"); return;
                }
                if (!DAO.DAOGenerarViaje.hayAeronavesDisponibles(Origen.value, Destino.value, fechaSalida.value, fechaLlegadaEstimada.value))
                {
                    MessageBox.Show("No hay aeronaves disponibles con ese recorrido");

                }
                DAO.DAOGenerarViaje.getRutas(Origen.value, Destino.value, fechaSalida.value, fechaLlegadaEstimada.value, rutas);
                NombreAeronave.clean();
                NombreAeronave.AddAll(DAO.DAOGenerarViaje.getAeronavesCompatibles(Convert.ToDecimal(rutas.Rows[0].Cells["col_codigo"].Value), fechaSalida.value, fechaLlegadaEstimada.value));

            }
        }




    }
}
