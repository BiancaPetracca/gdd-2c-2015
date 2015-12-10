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
            if (r != -1)
            {
                modificarButacas(dgButacas, aeronave.numero);
            }
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
        if (numeroAeronave != -1)
        {
            modificarButacas(dgButacas, numeroAeronave);
        }
        return numeroAeronave;
            
        }


        public static void modificarButacas(DataGridView dg, Decimal numeroAeronave)
        {
            foreach (DataGridViewRow row in dg.Rows)
            {
                if (!row.IsNewRow)
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

        internal static int cancelarViajesAeronavePorVidaUtil(decimal numero, DateTime baja)
        {
            return SqlConnector.executeProcedure("cancelarViajesAeronavePorVidaUtil", numero, baja);
        }

        internal static int reemplazarViajesPorVidaUtil(decimal numero, DateTime baja)
        {
           return SqlConnector.executeProcedure("reemplazarAeronavePorVidaUtil", numero, baja);
          
        }

        internal static int cancelarViajesAeronavePorMantenimiento(decimal numero, DateTime baja, DateTime reinicio)
        {
            return SqlConnector.executeProcedure("cancelarViajesAeronavePorMantenimiento", numero, baja, reinicio);
        }

        internal static int reemplazarViajesPorMantenimiento(decimal numero, DateTime baja, DateTime reinicio)
        {
            return SqlConnector.executeProcedure("reemplazarAeronavePorMantenimiento", numero, baja, reinicio);
           
        }

        internal static int bajaDeAeronave(decimal numero, DateTime baja, DateTime reinicio)
        {
            return SqlConnector.executeProcedure("bajaSinViajes", numero, baja, reinicio);
        }

        internal static String getMatricula(int numero) {
           return SqlConnector.retrieveList("get_matricula", "aero_matricula", numero).First();
        }
    }
}