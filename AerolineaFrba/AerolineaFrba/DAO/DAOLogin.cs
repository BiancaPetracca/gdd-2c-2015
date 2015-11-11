using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.DAO;

namespace AerolineaFrba.DAO
{
    public static class DAOLogin
    {

        // valida que coincida  el usuario con contraseña del mismo
        public static bool validarUsername(this Form aForm, String procedure, String username, String password)
        {
            return SqlConnector.ejecutarProcedureRetornaValor(procedure, username, password) == 1;
        }

        public static void loadLogin(String procedure)
        {
        }
    }
}
