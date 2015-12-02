using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.DAO;
using System.Windows.Forms;

namespace AerolineaFrba.DAO
{
    public static class DAORuta
    {
        public static void getRutas(DataGridView dg)
        {
            SqlConnector.retrieveDT("get_all_rutas", dg);
        }

        public static int modificarRuta(Model.Ruta rutaVieja, Model.Ruta rutaModificada)
        {
         
            if (SqlConnector.executeProcedure("modificar_ruta", rutaVieja.Codigo, rutaModificada.Origen, rutaModificada.Destino,
                rutaModificada.PrecioBaseKg, rutaModificada.PrecioBasePasaje) == -1) { return -1; };
            rutaVieja.Servicios.ForEach(servicio => { if (!rutaModificada.Servicios.Contains(servicio)) { borrarServicio(servicio, rutaModificada.Codigo); } });
            rutaModificada.Servicios.ForEach(servicio => { if (!rutaVieja.Servicios.Contains(servicio)) { agregarServicio(servicio, rutaModificada.Codigo); } });
            return 1;
        }

        public static int darDeBaja(Model.Ruta ruta)
        {
            return SqlConnector.executeProcedure("baja_ruta", ruta.Codigo);

        }

        public static Decimal darDeAlta(Model.Ruta ruta)
        {  
            ruta.Codigo = SqlConnector.executeProcedure("altaRutaAerea", ruta.Origen, ruta.Destino, ruta.PrecioBasePasaje, ruta.PrecioBaseKg, ruta.Habilitada ? 1 : 0);
            if (ruta.Codigo == -1) { return ruta.Codigo; }
            ruta.Servicios.ForEach(servicio => agregarServicio(servicio, ruta.Codigo));
            return ruta.Codigo;
        }

        public static int agregarServicio(String servicio, Decimal codigo) {
            return SqlConnector.executeProcedure("agregar_servicio", servicio, codigo);
        }

        public static int borrarServicio(String servicio, Decimal codigo) {
            return SqlConnector.executeProcedure("borrar_servicio", servicio, codigo);
        }

        public static List<String> getServicios(Decimal codigo)
        {
            return SqlConnector.retrieveList("get_servicios_rutas", "serv_nombre", codigo);
        }

        internal static bool tieneViajesAsignados(Decimal codigo)
        {
            return SqlConnector.executeProcedure("tiene_viajes_ruta", codigo) == 1 ? true : false;
        }
        internal static void filtrarRutas(String origen, String destino, DataGridView dg)
        {

            SqlConnector.retrieveDT("get_all_rutas", dg, origen, destino);
        }
    }
}
