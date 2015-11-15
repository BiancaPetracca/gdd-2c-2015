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
        public Aeronave(int numero, String modelo, String matricula, String fabricante, Decimal cantidadButacasPasillo,
            Decimal cantidadButacasVentanilla, Decimal kgsEncomiendas, Boolean estadoAeronave, /*DateTime fechaBaja,
            DateTime fechaReinicio, DateTime fechaBajaFueraServicio, DateTime fechaAlta,*/ String servicio)
        {

            this.numero = numero;
            this.modelo = modelo;
            this.matricula = matricula;
            this.fabricante = fabricante;
            this.cantidadButacasPasillo = cantidadButacasPasillo;
            this.cantidadButacasVentanilla = cantidadButacasVentanilla;
            this.kgsEncomiendas = kgsEncomiendas;
            this.estadoAeronave = estadoAeronave;
            /*   this.fechaBaja = fechaBaja;
               this.fechaReinicio = fechaReinicio;
               this.fechaBajaFueraServicio = fechaBajaFueraServicio;
               this.fechaAlta = fechaAlta; */
            this.servicio = servicio;
        }
        public int numero { get; set; }
        public String modelo { get; set; }
        public String matricula { get; set; }
        public String fabricante { get; set; }
        public Decimal cantidadButacasPasillo { get; set; }
        public Decimal cantidadButacasVentanilla { get; set; }
        public Decimal kgsEncomiendas { get; set; }
        public Boolean estadoAeronave { get; set; }
        public DateTime fechaBaja { get; set; }
        public DateTime fechaReinicio { get; set; }
        public DateTime fechaBajaFueraServicio { get; set; }
        public DateTime fechaAlta { get; set; }
        public String servicio { get; set; }


    }
}
