using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.DAO
{
    public class DAOProductos
    {

        public static List<String> listarProductos() {
           return SqlConnector.retrieveList("get_productos_disponibles", "prod_nombre");
        }

        public static int obtenerCantidadProducto(String producto){
            return SqlConnector.executeProcedure("get_stock_producto", producto);
        }

        public static int obtenerPuntosProducto(String producto)
        {
            return SqlConnector.executeProcedure("get_puntos_producto", producto);
        }
    }
}
