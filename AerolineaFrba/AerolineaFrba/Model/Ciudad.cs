using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class Ciudad{
        public String nombre_ciudad { get; set; }

        public Ciudad(String nombre_ciudad)
        {
            this.nombre_ciudad = nombre_ciudad;
        }
    }
}
