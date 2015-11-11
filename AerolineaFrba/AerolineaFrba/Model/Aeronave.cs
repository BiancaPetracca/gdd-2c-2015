using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace AerolineaFrba.DAO
{
    public class Aeronave
    {
        public  Aeronave aeronave { get; set; }
        public int numero { get; set; }
        public string modelo { get; set; }
        public string matricula { get; set; }
        public string fabricante { get; set; }
        public int cantidadButacas { get; set; }
        public int cantidadButacasPasillo { get; set; }
        public int cantidadButacasVentanilla { get; set; }
        public int kgsEncomiendas { get; set; }
        public int vidaUtil { get; set; }
        public string estadoAeronave { get; set; }
        public SqlDateTime? fechaBaja { get; set; }
        public SqlDateTime? fechaReinicio { get; set; }
        public SqlDateTime? fechaBajaTemporal { get; set; }
        public SqlDateTime? fechaAlta{ get; set; }
        public int servicio { get; set; }
    }
}
