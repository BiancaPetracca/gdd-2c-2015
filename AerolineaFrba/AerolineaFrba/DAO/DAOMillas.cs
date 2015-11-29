using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.DAO
{
    public class DAOMillas
    {
    
        internal static void clientesConMasMillas(DateTime dateTime1, DateTime dateTime2, DataGridView dg)
        {
            SqlConnector.retrieveDT("clientes_con_mas_millas_acumuladas", dg, dateTime1, dateTime2);
         
        }

        internal static void destinosConMasPasajesComprados(DateTime dateTime1, DateTime dateTime2, DataGridView dg)
        {
            SqlConnector.retrieveDT("destinos_pasajes_comprados", dg, dateTime1, dateTime2);
           
        }

        internal static void destinosConMasPasajesCancelados(DateTime dateTime1, DateTime dateTime2, DataGridView dg)
        {
           SqlConnector.retrieveDT("destinos_con_mas_pasajes_cancelados", dg, dateTime1, dateTime2);

        }

        internal static void AeronavesConMasVecesFueraDeServicio(DateTime dateTime1, DateTime dateTime2, DataGridView dg)
        {
            SqlConnector.retrieveDT("aeronaves_mas_fuera_de_servicio", dg, dateTime1, dateTime2);
        }

        internal static void destinosConMasAeronavesVacias(DateTime dateTime1, DateTime dateTime2, DataGridView dg)
        {
           SqlConnector.retrieveDT("destinos_aeronaves_mas_vacias", dg, dateTime1, dateTime2);
        }





        internal static void canjearProductos(DataGridView ProductosCanjear, String tipoDNI, Object DNI)
        {
            foreach(DataGridViewRow row in ProductosCanjear.Rows){
                SqlConnector.executeProcedure("canjear_productos", tipoDNI, Convert.ToDecimal(DNI), row.Cells["col_producto_canjear"].Value.ToString(),
                    Convert.ToDecimal(row.Cells["col_cantidad"].Value));
        }}

        internal static void getMillasCanjes(DataGridView canjes, String tipoDNI, String DNI)
        {
            SqlConnector.retrieveDT("info_canjes", canjes, tipoDNI, DNI);
        }

        internal static void getMillasPasajes(DataGridView pasajes, String tipoDNI, String DNI)
        {
            SqlConnector.retrieveDT("info_pasajes", pasajes, tipoDNI, DNI);
        } 

        internal static void getMillasEncomiendas(DataGridView encomiendas, String tipoDNI, String DNI)
        {
            SqlConnector.retrieveDT("info_encomiendas", encomiendas, tipoDNI, DNI);
        }
    }
}
