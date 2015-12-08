using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class Item
    {
        public String tipoDoc { get; set; }
        public Decimal nroDoc { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String direccion { get; set; }
        public Decimal telefono { get; set; }
        public String mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Decimal butaca { get; set; }
        public String tipoButaca { get; set; }
        public Decimal kgsEncomienda { get; set; }

        public Item(String tipoDoc, Decimal nroDoc, String nombre, String apellido, String direccion, Decimal telefono,
            String mail, DateTime fechaNacimiento, Decimal butaca, String tipoButaca, Decimal kgsEncomienda) {
                this.tipoDoc = tipoDoc;
                this.nroDoc = nroDoc;
                this.nombre = nombre;
                this.apellido = apellido;
                this.direccion = direccion;
                this.telefono = telefono;
                this.mail = mail;
                this.fechaNacimiento = fechaNacimiento;
                this.butaca = butaca;
                this.tipoButaca = tipoButaca;
                this.kgsEncomienda = kgsEncomienda;
        
        
        }
    }
}
