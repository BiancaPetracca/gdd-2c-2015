using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class Compra
    {
        public Compra compra { get; set; }
        public Decimal codigo { get; set; }
        public DateTime fecha { get; set; }
        public String ciudadOrigen { get; set; }
        public String ciudadDestino { get; set; }
        public String servicio { get; set; }
        public Double kgsEncomienda { get; set; }
        public int pasajes { get; set; }
        public int Terminal { get; set; }
        public Model.Usuario User { get; set; }

        public Compra() { }
        public Compra(Decimal Codigo)
        {
            this.codigo = codigo;
        }


    }
}
