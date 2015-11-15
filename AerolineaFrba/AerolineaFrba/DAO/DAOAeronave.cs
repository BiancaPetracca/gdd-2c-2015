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

        public static int tieneViajesAsignados(String matricula)
        {
            return SqlConnector.executeProcedure("tiene_viajes_asignados", matricula);
        }

        public static int bajaDeAeronave(int tipoBaja, int reasignarOCancelar, String matricula, DateTime fechaReinicio)
        {
            // cancelar 0 reasignar 1
            // tipoBaja 0 : fin de vida util, 1: mantenimiento

            // si llega a pasar que le doy de baja a una aeronave y no tenia viajes asociados, da lo mismo poner un 1 o un 0 en reasignar o cancelar
            // de todas formas no va a reasignar ni cancelar nada. 

            if (tipoBaja == 0)
            {
                return SqlConnector.executeProcedure("bajaLogicaDeAeronavePorFinDeVidaUtil", matricula, reasignarOCancelar);
            }
            return SqlConnector.executeProcedure("bajaLogicaDeAeronavePorMantenimiento", matricula, fechaReinicio, reasignarOCancelar);
        }

        public static int existeAeronaveQueReemplace(String matricula) {
            return SqlConnector.executeProcedure("existeAeronaveQueReemplace", matricula);
        }

        public static int modificarAeronave(Model.Aeronave aeronave) {
            return SqlConnector.executeProcedure("modificarAeronave", aeronave.numero, aeronave.matricula, aeronave.modelo, aeronave.fabricante,
                aeronave.servicio, aeronave.kgsEncomiendas, aeronave.cantidadButacasVentanilla, aeronave.cantidadButacasPasillo, aeronave.estadoAeronave? 1 : 0);
        }

        public static int obtenerCodigoAeronave(Model.Aeronave aeronave) {
            return SqlConnector.executeProcedure("obtenerCodigoAeronave", aeronave.matricula);
        }

        public static int obtenerCodigoAeronave(String aeronave)
        {
            return SqlConnector.executeProcedure("obtenerCodigoAeronave", aeronave);
        }
    }
}