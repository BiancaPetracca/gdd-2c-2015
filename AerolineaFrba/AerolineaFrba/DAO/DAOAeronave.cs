using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;


namespace AerolineaFrba.DAO
{
    public static class DAOAeronave

    {

        public static void listarAeronaves(System.Windows.Forms.DataGridView dg)
        {
            DataTable dt = SqlConnector.retrievingDT("get_aeronaves", null);
            
            SqlConnector.bindNamesToDataTable(dt, dg);
            SqlConnector.loadWithDataTable(dt, dg);


        }

        private static Aeronave convertirAeronave(DataRow dataRow,Aeronave aero)
        {
            
            aero.matricula = dataRow["aero_matricula"].ToString();
            aero.fabricante = dataRow["aero_fabricante"].ToString();
            aero.cantidadButacas = Convert.ToInt32(dataRow["aero_cantidad_butacas_ventanilla"]) + Convert.ToInt32(dataRow["aero_cantidad_butacas_pasillo"]); 
            aero.kgsEncomiendas = Convert.ToInt32(dataRow["aero_kgs_disponibles_encomiendas"]);

            if ((dataRow["aero_fecha_baja_definitiva"] == (System.DBNull.Value)))
            {
                aero.fechaBaja = null;
            }
            else 
            {
                aero.fechaBaja = Convert.ToDateTime(dataRow["aero_fecha_baja_definitiva"]);
            };

            if ((dataRow["aero_fecha_de_alta"]) == (System.DBNull.Value))
            {
                aero.fechaAlta = null;
            }
            else 
            {
                aero.fechaAlta = Convert.ToDateTime(dataRow["aero_fecha_de_alta"]);
            };



            if (Convert.ToInt32(dataRow["aero_estado"]) == 1)
            {
                aero.estadoAeronave = "Habilitada";
            }
            else
            {
                aero.estadoAeronave = "Deshabilitada";
            } 
           // aero.fechaBaja = Convert.ToDateTime(dataRow["aero_baja_fuera_de_servicio"]);
           // aero.fechaReinicio = Convert.ToDateTime(dataRow["aero_fecha_reinicio_servicio"]);
            //aero.servicio = Convert.ToInt32(dataRow["serv_id_servicio"]);

            return aero;
        }
    }
}
