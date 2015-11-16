using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.DAO;
using AerolineaFrba.Generics;

namespace AerolineaFrba.DAO
{
    public static class DAOLogin
    {
   

        // valida que coincida  el usuario con contraseña del mismo
        public static int validarUsername(String username, string password, String rol)
        {
            
            return SqlConnector.executeProcedure("validar_usuario", username, Crypto.getSHA256(password), rol);
        }


        public static int inhabilitarUsuario(Model.Usuario usuario)
        {
            return SqlConnector.executeProcedure("inhabilitar_usuario", usuario.Username);
        }

        public static int obtenerRolUsuario(Model.Usuario usuario) {
            return SqlConnector.executeProcedure("get_rol_usuario", usuario.Username);
        }

        public static int getEstado(Model.Usuario usuario) {
            return SqlConnector.executeProcedure("get_estado_usuario", usuario.Username);
        }
    }
}
