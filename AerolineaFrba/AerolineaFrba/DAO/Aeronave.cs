using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AerolineaFrba.DAO
{
    public class Aeronave
    {
        public  Aeronave aeronave { get; set; }
        public string matricula { get; set; }
        public  string fabricante { get; set; }
        public  int cantidadButacas { get; set; }
        public int kgsEncomiendas { get; set; }
        public int vidaUtil { get; set; }
        public string estadoAeronave { get; set; }
        public DateTime fechaBaja { get; set; }
        public DateTime fechaReinicio { get; set; }
        public string servicio { get; set; }
    }
}
