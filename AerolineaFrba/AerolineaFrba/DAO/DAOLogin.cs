using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.DAO;
using System.Windows.Forms;

namespace AerolineaFrba.DAO
{
    public static class DAORuta
    {   
 
        public static bool validarUsername(this Form aForm, String procedure, String username,String password)
        {
            return SqlConnector.ejecutarProcedureRetornaValor(procedure,username,password) == 1;
        }

        public static void loadLogin(String procedure) { 



        }
    }
}
