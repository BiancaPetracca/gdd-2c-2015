using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class Viaje
    {
        public decimal encomiendas { get; set; }
        public string servicio { get; set; }
        public decimal codigo { get; set; }
        /*    public Aeronave aeronave { get; set; }
            public Ciudad ciudadOrigen { get; set; }
            public Ciudad ciudadDestino { get; set; }
            public DateTime fechaSalida { get; set; }
            public DateTime fechaLlegada { get; set; }
            public DateTime fechaLlegadaEstimada { get; set; } 

            public Viaje() { }

            public Viaje(Aeronave aeronave, Ciudad ciudadOrigen, Ciudad ciudadDestino, DateTime fechaLlegada) {
                this.aeronave = aeronave;
                this.ciudadOrigen = ciudadOrigen;
                this.ciudadDestino = ciudadDestino;
                this.fechaLlegada = fechaLlegada;
            } */

        public String matricula { get; set; }
        public String ciudadOrigen { get; set; }
        public String ciudadDestino { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegada { get; set; }
        public DateTime fechaLlegadaEstimada { get; set; }

        public Viaje() { }

        public Viaje(String matricula, String ciudadOrigen, String ciudadDestino, DateTime fechaLlegada)
        {
            this.matricula = matricula;
            this.ciudadOrigen = ciudadOrigen;
            this.ciudadDestino = ciudadDestino;
            this.fechaLlegada = fechaLlegada;
        }

        public Viaje(String ciudadOrigen, String ciudadDestino, DateTime fechaSalida, DateTime fechaLlegadaEstimada)
        {
            this.matricula = matricula;
            this.ciudadOrigen = ciudadOrigen;
            this.ciudadDestino = ciudadDestino;
            this.fechaSalida = fechaSalida;
            this.fechaLlegadaEstimada = fechaLlegadaEstimada;
        }

        public Viaje(Decimal codigo, DateTime fechaSalida, DateTime fechaLlegadaEstimada, String ciudadOrigen, String ciudadDestino, String servicio, 
            Decimal butacasDisponibles, Decimal encomiendas)
        {
            this.codigo = codigo;
            this.servicio = servicio;
            this.butacasDisponibles = butacasDisponibles;
            this.encomiendas = encomiendas;
            this.matricula = matricula;
            this.ciudadOrigen = ciudadOrigen;
            this.ciudadDestino = ciudadDestino;
            this.fechaSalida = fechaSalida;
            this.fechaLlegadaEstimada = fechaLlegadaEstimada;
        }

        public decimal butacasDisponibles { get; set; }
    }
}
