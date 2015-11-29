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
        public static int get_millas(DataGridView dg, String tipo_dni, Decimal dni) {
            return SqlConnector.retrieveDT("info_millas", dg, tipo_dni, dni);
        }

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
        



    }
}
