using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AerolineaFrba.Model;
using System.Windows.Forms;

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

        public static List<String> listarCompras(String tipo, Object doc)
        {
            return SqlConnector.retrieveList("get_compras", "compra_id", tipo, Convert.ToDecimal(doc));
        }

        public static List<String> listarEncomiendas(Decimal compra)
        {
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
            SqlConnector.retrieveDT("get_viajes", dataGridView, salida, llegada, origen, destino);
        }

        public static bool hayViajesDisponibles(Viaje viaje)
        {
            return SqlConnector.executeProcedure("hay_viajes_disponibles", viaje.fechaSalida, viaje.fechaLlegadaEstimada, viaje.ciudadOrigen, viaje.ciudadDestino) == 1 ? true : false;
        }

        internal static int prepararCompra(List<Item> items, Decimal viaje)
        {
            int codigoCompra = SqlConnector.executeProcedure("crear_compra");
            items.ForEach(item =>
               SqlConnector.executeProcedure("preparar_compra", codigoCompra, item.tipoDoc, item.nroDoc, 
                  item.nombre, item.apellido, item.direccion, item.telefono, item.mail, item.fechaNacimiento, item.butaca, item.tipoButaca, item.kgsEncomienda, viaje));
            
            return codigoCompra;
        }

        public static void cancelarCompra(Decimal codigo) {

            SqlConnector.executeProcedure("cancelar_compra", codigo);
        }


        internal static decimal cuotasMaximasTarjeta(string p)
        {
           return SqlConnector.executeProcedure("cuotas_maximas_tarjeta", p);
        }

        internal static int efectuarCompra(Cliente cliente, Decimal codigoCompra, decimal Pago, decimal cuotas)
        {
               return SqlConnector.executeProcedure("efectuar_compra", codigoCompra, cliente.Codigo, Pago, cuotas);
 
        }

        internal static decimal getTipoPago(string p)
        {
            return SqlConnector.executeProcedure("getTipoPago", p);
        }

        internal static void getEncomiendas(decimal codigo, DataGridView compra)
        {
            SqlConnector.retrieveDT("detalle_encomiendas", compra, codigo);
        }

        internal static void getPasajes(decimal codigo, DataGridView compra)
        {
            SqlConnector.retrieveDT("detalle_pasajes", compra, codigo);
        }

        internal static void getCompra(decimal codigo, DataGridView compra)
        {
            SqlConnector.retrieveDT("detalle_compra", compra, codigo);
        }

        internal static Boolean clienteYaTienePasaje(DateTime salida, DateTime llegada, String tipoDoc, String nroDoc)
        {
            return SqlConnector.executeProcedure("ya_tiene_pasaje", salida, llegada, tipoDoc, Convert.ToDecimal(nroDoc)) == 1? true : false;
        }
    }
}
