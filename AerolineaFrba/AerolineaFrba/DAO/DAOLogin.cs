using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.DAO;

namespace AerolineaFrba.DAO
{
    public class DAOLogin: SqlConnector
    {   
        //todo ver si se puede mandar todo en uno para no repetir la misma logica,
        //en sql estan los procedures separados para validar username y password
        //TODO
        public bool validarUsername(String procedure, String username,String password)
        {
            return SqlConnector.ejecutarProcedureRetornaValor(procedure,username,password) == 1;
        }
    }
}
