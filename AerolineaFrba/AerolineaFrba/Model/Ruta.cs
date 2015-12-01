using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class Ruta
    {
        private Decimal codigo { get; set; }
        private String origen { get; set; }
        private String destino { get; set; }
        private Boolean habilitada { get; set; }
        private List<String> servicios { get; set; }
        private Decimal precioBaseKg { get; set; }
        private Decimal precioBasePasaje { get; set; }

        public Decimal Codigo { get { return codigo; } set { codigo = value; } }
        public String Origen { get{return origen;} set{origen = value;} }
        public String Destino { get {return destino;} set{destino = value;} }
        public Boolean Habilitada { get {return habilitada;} set{habilitada = value;} }
        public List<String> Servicios { get {return servicios;} set{servicios = value;} }
        public Decimal PrecioBaseKg { get {return precioBaseKg;} set{precioBaseKg = value;} }
        public Decimal PrecioBasePasaje { get { return precioBasePasaje; } set { precioBasePasaje = value; } }

        public Ruta(){}

        public Ruta(String origen, String destino, Boolean habilitada, List<String> servicios, Decimal precioBaseKg, Decimal precioBasePasaje){
        this.origen = origen;
        this.destino = destino;
        this.habilitada = habilitada;
        this.servicios = servicios;
        this.precioBaseKg = precioBaseKg;
        this.precioBasePasaje = precioBasePasaje;
        }

        public Ruta(Decimal codigo, String origen, String destino, Boolean habilitada, List<String> servicios, Decimal precioBaseKg, Decimal precioBasePasaje)
        {
            this.codigo = codigo;
            this.origen = origen;
            this.destino = destino;
            this.habilitada = habilitada;
            this.servicios = servicios;
            this.precioBaseKg = precioBaseKg;
            this.precioBasePasaje = precioBasePasaje;
        }
    }
}
