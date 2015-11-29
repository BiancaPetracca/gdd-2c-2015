using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AerolineaFrba.Model;

namespace AerolineaFrba.DAO
{
    public static class DAOCompra
    {

        // lista todas las ciudades que hay y las agrega 
        public static List<Ciudad> listCiudades()
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            foreach (DataRow row in SqlConnector.retrieveDT("get_ciudades").Rows)
            {
                ciudades.Add(new Ciudad(row["ciu_nombre"].ToString()));
            }
            return ciudades;
        }

        public static List<String> listarCiudades()
        {
            List<String> ciudades = new List<String>();
            foreach (DataRow row in SqlConnector.retrieveDT("get_ciudades").Rows)
            {
                ciudades.Add(row["ciu_nombre"].ToString());
            }
            return ciudades;
        }

        public static List<String> listarCompras(Decimal dni)
        {
           return SqlConnector.retrieveList("get_compras", "compra_id", dni);
        }

        public static List<String> listarEncomiendas(Decimal compra) {
            return SqlConnector.retrieveList("get_encomiendas", "enc_codigo", compra);
        }

        public static List<String> listarPasajes(Decimal compra)
        {
            return SqlConnector.retrieveList("get_pasajes", "pas_codigo", compra);
        }

        public static Decimal crearDevolucion(Decimal compra)
        {
            return SqlConnector.executeProcedure("crear_devolucion", compra);
        }

        public static int devolverItems(Decimal devolucion, Decimal item, String motivo)
        {
            return SqlConnector.executeProcedure("devolver_items", devolucion, item, motivo);
        }

        public static void encontrarViajes(System.Windows.Forms.DataGridView dataGridView, String origen, String destino, DateTime salida, DateTime llegada)
        {
            SqlConnector.retrieveDT("encontrar_viajes", dataGridView, origen, destino, salida, llegada);
        }

        public static bool hayViajesDisponibles(Viaje viaje)
        {
            return SqlConnector.executeProcedure("hay_viajes_disponibles", viaje.ciudadOrigen, viaje.ciudadDestino, viaje.fechaSalida, viaje.fechaLlegadaEstimada) == 1 ? true : false;
        }
    }
}
