using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.DAO
{
    public class Compra
    {
        public Compra compra { get; set; }
        public DateTime fecha {get; set;}
        public String ciudadOrigen { get; set; }
        public String ciudadDestino { get; set; }
        public String servicio { get; set; }
        public Double kgsEncomienda { get; set; }
        public int pasajes { get; set; }


    }
}
