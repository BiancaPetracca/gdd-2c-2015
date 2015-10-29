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
        List<String> ciudades;
        public Generar_Viaje()
        {
            InitializeComponent();
          //  ciudades = DAORuta.getAllCiudad("get_all_cities");
        }

        private void fechaLlegadaEstimada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechaLlegada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
           //this.validateNotNullForAll(this.Controls);
           this.domainValidations(noPuedeTardarMasDe24HorasEnLlegar);

            // GENERAR_VIAJE // 
            // CONTROLAR SERVICIO DE RUTA CONCUERDE CON SERVICIO DE AERONAVE
            // AERONAVE DISPONIBLE + NO ASIGNADA A OTRO VIAJE YA
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Origen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }


        private Boolean noPuedeTardarMasDe24HorasEnLlegar() {

            TimeSpan tiempoEnLlegarEstimado = (this.fechaSalida.Value).Subtract(this.fechaLlegadaEstimada.Value);

            return tiempoEnLlegarEstimado.TotalHours <= 24;
        }

        private void Generar_Viaje_Load(object sender, EventArgs e)
        {

        }

    }
}
