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
        public static int validarUsername(String username, string password)
        {
            
            return SqlConnector.executeProcedure("validar_usuario", username, Crypto.getSHA256(password));
        }


        public static String obtenerRolUsuario(Model.Usuario usuario) {
            return SqlConnector.retrieveList("get_rol", "rol_nombre", usuario.Username).First();
        }

        internal static int aumentarIntentos(Model.Usuario user)
        {
            return SqlConnector.executeProcedure("aumentar_intentos", user.Username);
        }

        internal static int vaciarIntentos(Model.Usuario user)
        {
            return SqlConnector.executeProcedure("vaciar_intentos", user.Username);
        }

        internal static int getIntentos(Model.Usuario user)
        {
           return SqlConnector.executeProcedure("get_intentos", user.Username);
        }

        internal static Boolean existeUsuario(String username)
        {
            return SqlConnector.executeProcedure("existe_usuario", username) == 1 ? true : false;
        }

        internal static List<short> getFuncionalidades(int p)
        {
            throw new NotImplementedException();
        }

        internal static int obtenerIDRolUsuario(Model.Usuario user)
        {
            return SqlConnector.executeProcedure("get_id_rol_usuario", user.Username);
        }
    }
}
