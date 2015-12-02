using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class Rol
    {
        public Decimal id { get; set; }
        public String nombre { get; set; }
        public Boolean habilitado { get; set; }
        public List<String> funcionalidades;

        public Rol() { }
        public Rol(String nombre, Boolean habilitado, List<String> funcionalidades) {
            this.nombre = nombre;
            this.habilitado = habilitado;
            this.funcionalidades = funcionalidades;

        }

        public Rol(String nombre, Boolean habilitado) {
            this.nombre = nombre;
            this.habilitado = habilitado;
        }

        public Rol(Decimal id, String nombre, Boolean habilitado)
        {
            this.id = id;
            this.nombre = nombre;
            this.habilitado = habilitado;
            

        }
    }
}
