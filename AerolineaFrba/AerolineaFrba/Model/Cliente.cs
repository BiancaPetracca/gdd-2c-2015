using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class Cliente
    {
        public Decimal Codigo {get; set;}
        public String TipoDNI { get; set; }
        public Decimal DNI { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }
        public String Mail { get; set; }
        public Decimal Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }


        public Cliente(String TipoDNI, Decimal DNI, String Nombre, String Apellido, String Direccion, String Mail, Decimal Telefono, DateTime FechaNacimiento) {

            this.TipoDNI = TipoDNI;
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Mail = Mail;
            this.Telefono = Telefono;
            this.FechaNacimiento = FechaNacimiento;
        }
         
    }
}
