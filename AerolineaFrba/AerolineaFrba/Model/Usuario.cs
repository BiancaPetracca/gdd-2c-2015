using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class Usuario
    {
        private String username { get; set; }
        private String password { get; set; }
        private int intentos { get; set; }
        private int estado {get; set;}
        private String rol {get; set;}
        public String Username { get { return username; } set { username = value; } }
        public String Password { get { return password; } set { password = value; } }
        public int Intentos { get { return intentos; } set { intentos = value; } }
        public int Estado { get { return estado; } set { estado = value; } }
        public String Rol {get {return rol; } set {rol = value; }}

        public Usuario(String username, String password) {
            this.username = username;
            this.password = password;
            this.intentos = 0;
        }
    }
}
