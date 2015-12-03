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
            SqlConnector.retrieveDT("get_aeronaves", dg);

        }

        public static void filtrarAeronaves(DataGridView dg, Boolean estado, String filtro)
        {
            SqlConnector.retrieveDT("get_aeronaves", dg, estado, filtro);

        }




        //private static Aeronave convertirAeronave(DataRow dataRow, Aeronave aero)
        //{

        //    aero.matricula = dataRow["aero_matricula"].ToString();
        //    aero.fabricante = dataRow["aero_fabricante"].ToString();
        //    aero.cantidadButacas = Convert.ToInt32(dataRow["aero_cantidad_butacas_ventanilla"]) + Convert.ToInt32(dataRow["aero_cantidad_butacas_pasillo"]);
        //    aero.kgsEncomiendas = Convert.ToInt32(dataRow["aero_kgs_disponibles_encomiendas"]);

        //    if ((dataRow["aero_fecha_baja_definitiva"] == (System.DBNull.Value)))
        //    {
        //        aero.fechaBaja = null;
        //    }
        //    else
        //    {
        //        aero.fechaBaja = Convert.ToDateTime(dataRow["aero_fecha_baja_definitiva"]);
        //    };

        //    if ((dataRow["aero_fecha_de_alta"]) == (System.DBNull.Value))
        //    {
        //        aero.fechaAlta = null;
        //    }
        //    else
        //    {
        //        aero.fechaAlta = Convert.ToDateTime(dataRow["aero_fecha_de_alta"]);
        //    };



        //    if (Convert.ToInt32(dataRow["aero_estado"]) == 1)
        //    {
        //        aero.estadoAeronave = "Habilitada";
        //    }
        //    else
        //    {
        //        aero.estadoAeronave = "Deshabilitada";
        //    }
        //    // aero.fechaBaja = Convert.ToDateTime(dataRow["aero_baja_fuera_de_servicio"]);
        //    // aero.fechaReinicio = Convert.ToDateTime(dataRow["aero_fecha_reinicio_servicio"]);
        //    //aero.servicio = Convert.ToInt32(dataRow["serv_id_servicio"]);

        //    return aero;
        //}

        public static int tieneViajesAsignados(Decimal numero, DateTime fechaBaja, Nullable<DateTime> fechaReinicio)
        {
            return SqlConnector.executeProcedure("tiene_viajes_asignados", numero, fechaBaja, fechaReinicio);
        }

        public static int tieneViajesAsignados(Decimal numero) {
            return SqlConnector.executeProcedure("tiene_viajes_asignados_siempre", numero);
        }

        public static int existeAeronaveQueReemplace(String matricula)
        {
            return SqlConnector.executeProcedure("existeAeronaveQueReemplace", matricula);
        }

        public static int modificarAeronave(Model.Aeronave aeronave, DataGridView dgButacas)
        {
            int r = SqlConnector.executeProcedure("modificarAeronave", aeronave.numero, aeronave.matricula, aeronave.modelo, aeronave.fabricante,
                aeronave.servicio, aeronave.kgsEncomiendas, aeronave.estadoAeronave ? 1 : 0);
            modificarButacas(dgButacas, aeronave.numero);
            return r;
        }

        public static int obtenerCodigoAeronave(Model.Aeronave aeronave)
        {
            return SqlConnector.executeProcedure("obtenerCodigoAeronave", aeronave.matricula);
        }

        public static int obtenerCodigoAeronave(String aeronave)
        {
            return SqlConnector.executeProcedure("obtenerCodigoAeronave", aeronave);
        }

        public static int altaDeAeronave(Model.Aeronave aeronave, DataGridView dgButacas)
        { int numeroAeronave = SqlConnector.executeProcedure("altaDeAeronave", aeronave.matricula, aeronave.modelo, aeronave.fabricante,
                aeronave.servicio, aeronave.kgsEncomiendas);
        modificarButacas(dgButacas, numeroAeronave);
        return numeroAeronave;
            
        }


        public static void modificarButacas(DataGridView dg, Decimal numeroAeronave)
        {
            foreach (DataGridViewRow row in dg.Rows)
            {
                if (row.Index < dg.Rows.Count -1)
                {
                     SqlConnector.executeProcedure("set_butacas", numeroAeronave, Convert.ToDecimal(row.Cells["col_butaca"].Value), Convert.ToString(row.Cells["col_tipo"].Value));
                }
            }

        }

        public static int getModelos(String fabricante, DataGridView dg)
        {
            return SqlConnector.retrieveDT("getModelos", dg, fabricante);
        }

        public static List<String> listarModelos(String fabricante) {
            return SqlConnector.retrieveList("getModelos", "mod_nombre", fabricante);
        }

        public static List<String> listarFabricantes() {
            return SqlConnector.retrieveList("getFabricantes", "fab_nombre");
        }

        public static int modificarModelo(String viejoNombre, String nuevoNombre, String fabricante)
        {
            return SqlConnector.executeProcedure("modificarModelo", viejoNombre, nuevoNombre, fabricante);
        }

        public static int agregarModelo(String nombre, String fabricante)
        {
            return SqlConnector.executeProcedure("agregarModelo", nombre, fabricante);
        }


        public static int getButacas(Decimal avion, DataGridView dg)
        {
            return SqlConnector.retrieveDT("get_butacas", dg, avion);
        }

        public static int getNumeroAeronave(String matricula)
        {
            return SqlConnector.executeProcedure("get_id_aeronave", matricula);
        }

        public static int estaHabilitada(Decimal avion)
        {
            return SqlConnector.executeProcedure("get_estado_aeronave", avion);
        }

        public static int getButacasDisponibles(Model.Viaje viaje, DataGridView dg)
        {
            return SqlConnector.retrieveDT("get_butacas_disponibles", dg, viaje.codigo);
        }

        public static int modificarEstadoButaca(Decimal viaje, Decimal butaca, int estado)
        {
            return SqlConnector.executeProcedure("set_butaca_ocupada", viaje, butaca, estado);
        }

        internal static int cancelarViajesAeronave(decimal numero, DateTime baja, DateTime reinicio)
        {
            return SqlConnector.executeProcedure("cancelarViajesAeronave", numero, baja, reinicio);
        }

        internal static int reemplazarViajes(decimal numero, DateTime baja, DateTime reinicio)
        {
           return SqlConnector.executeProcedure("reemplazarAeronave", numero, baja, reinicio);
        }

        internal static int bajaDeAeronave(decimal numero, DateTime baja, DateTime reinicio)
        {
            return SqlConnector.executeProcedure("bajaSinViajes", numero, baja, reinicio);
        }
    }
}