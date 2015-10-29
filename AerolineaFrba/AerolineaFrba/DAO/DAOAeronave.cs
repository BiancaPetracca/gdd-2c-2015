using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AerolineaFrba.DAO
{
    public class DAOAeronave 
    {

        public List<Aeronave> listarAeronaves()
        {
            Aeronave a = new Aeronave();

            DateTime fecha = new DateTime(29102015);

            
            List<Aeronave> aeronaves = new List<Aeronave>();
            DataTable dataTable = this.retrieveDataTable("get_all_aeronaves", a.numero, "null", "null", a.cantidadButacasPasillo
                                        , a.cantidadButacasVentanilla, a.kgsEncomiendas, "null", Convert.ToDateTime(a.fechaAlta),
                                        Convert.ToDateTime(a.fechaBajaTemporal), Convert.ToDateTime(a.fechaReinicio)
                                        , Convert.ToDateTime(a.fechaBaja));
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Aeronave aero = convertirAeronave(dataRow);
                aeronaves.Add(aero);
            }

            return aeronaves;

        }

        private static Aeronave convertirAeronave(DataRow dataRow)
        {
            Aeronave aero = new Aeronave();
            aero.matricula = dataRow["aero_matricula"].ToString();
            aero.fabricante = dataRow["aero_faricante"].ToString();
            aero.cantidadButacas = Convert.ToInt32(dataRow["aero_cantidad_butacas_ventanilla"]) + Convert.ToInt32(dataRow["aero_cantidad_butacas_pasillo"]); 
            aero.kgsEncomiendas = Convert.ToInt32(dataRow["aero_kgs_disponibles_encomiendas"]);
            aero.vidaUtil = Convert.ToInt32(Convert.ToDateTime(dataRow["aero_fecha_baja_definitiva"]) - Convert.ToDateTime(dataRow["aero_fecha_de_alta"]));
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
            aero.servicio = dataRow["serv_nombre"].ToString();

            return aero;
        }
    }
}
