using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.DAO
{
    public class DAOUsuario
    {

        public static int elClienteExiste(String dni) {
            return SqlConnector.executeProcedure("existe_cliente", Convert.ToInt16(dni));
        }

        public static int obtenerMillasCliente(String dni) { 
        return SqlConnector.executeProcedure("get_millas_cliente", Convert.ToInt16(dni));
        }

        public static Boolean leAlcanzanLasMillas(String dni, String producto) {
            return obtenerMillasCliente(dni) > SqlConnector.executeProcedure("get_puntos_producto", producto);
        }
    }
}
