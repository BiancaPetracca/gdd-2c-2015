using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.DAO
{
    public class DAOCliente
    {
        public static Boolean existeCliente(Decimal dni)
        {
            return (SqlConnector.executeProcedure("existe_cliente", dni) == 1 ? true : false) ;
        }

        public static int completarDatos(int dni, DataGridView dg)
        {
            return SqlConnector.retrieveDT("get_cliente", dg, dni);
        }
    }
}
