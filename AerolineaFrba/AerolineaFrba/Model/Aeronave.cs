using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace AerolineaFrba.Model
{
    public class Aeronave
    {
        public Aeronave() { }
        public Aeronave(String matricula) {
            this.matricula = matricula;
        }
        public Aeronave(int numero, String modelo, String matricula, String fabricante, Decimal kgsEncomiendas, Boolean estadoAeronave, /*DateTime fechaBaja,
            DateTime fechaReinicio, DateTime fechaBajaFueraServicio, DateTime fechaAlta,*/ String servicio)
        {

            this.numero = numero;
            this.modelo = modelo;
            this.matricula = matricula;
            this.fabricante = fabricante;
         
            this.kgsEncomiendas = kgsEncomiendas;
            this.estadoAeronave = estadoAeronave;
            this.servicio = servicio;
        }
        public int numero { get; set; }
        public String modelo { get; set; }
        public String matricula { get; set; }
        public String fabricante { get; set; }
        public Decimal butacas { get; set; }
        public Decimal kgsEncomiendas { get; set; }
        public Boolean estadoAeronave { get; set; }
        public DateTime fechaBaja { get; set; }
        public DateTime fechaReinicio { get; set; }
        public DateTime fechaBajaFueraServicio { get; set; }
        public DateTime fechaAlta { get; set; }
        public String servicio { get; set; }

// DECIDIMOS QUE LOS TIPOS DE BUTACA SI ES IMPAR ES DE PASILLO Y SI ES PAR, ES DE VENTANILLA.
        public String tipoDeButaca(int numero)
        {
            if ((numero % 2) == 0)
            {
                return "Pasillo";
            }
            return "Ventanilla";
        }



    }
}
