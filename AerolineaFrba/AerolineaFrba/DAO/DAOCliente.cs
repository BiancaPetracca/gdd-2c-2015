using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.DAO
{
    public class DAOCliente
    {
        public static Boolean existeCliente(Decimal dni)
        {
            return (SqlConnector.executeProcedure("existe_cliente", dni) == 1 ? true : false) ;
        }
    }
}
