using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.DAO
{
    public class DAOCliente
    {
        public static Boolean existeCliente(String tipoDNI, Object dni)
        {
            return (SqlConnector.executeProcedure("existe_cliente", tipoDNI, Convert.ToDecimal(dni)) == 1 ? true : false) ;
        }

        public static void completarDatos(String tipoDNI, Object dni, DataGridView dg)
        {
           SqlConnector.LoadWithRow("get_cliente", dg.CurrentRow.Index, dg, tipoDNI, Convert.ToDecimal(dni));
            
        }

        public static int obtenerMillasCliente(String tipoDNI, String dni)
        {
            Decimal nroDNI = Convert.ToDecimal(dni);
            return (SqlConnector.executeProcedure("get_millas_cliente", tipoDNI, nroDNI));
           /* return (SqlConnector.executeProcedure("get_millas_pasajes", tipoDNI, nroDNI) +
                SqlConnector.executeProcedure("get_millas_encomiendas", tipoDNI, nroDNI) -
                SqlConnector.executeProcedure("get_millas_canjes", tipoDNI, nroDNI)); */
        }
    }
}
