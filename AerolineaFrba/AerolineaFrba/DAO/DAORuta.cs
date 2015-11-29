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

        public static int modificarRuta(Model.Ruta rutaVieja, Model.Ruta ruta)
        {
            int habil = ruta.Habilitada ? 1 : 0;
            if (SqlConnector.executeProcedure("modificar_ruta", rutaVieja.Codigo, ruta.Origen, ruta.Destino, habil,
                ruta.PrecioBaseKg, ruta.PrecioBasePasaje) == -1) { return -1; };
            rutaVieja.Servicios.ForEach(servicio => { if (!ruta.Servicios.Contains(servicio)) { borrarServicio(servicio, ruta.Codigo); } });
            ruta.Servicios.ForEach(servicio => { if (!rutaVieja.Servicios.Contains(servicio)) { agregarServicio(servicio, ruta.Codigo); } });
            return 1;
        }

        public static int darDeBaja(Model.Ruta ruta)
        {
            return SqlConnector.executeProcedure("bajaRutaAerea", ruta.Codigo);

        }

        public static int darDeAlta(Model.Ruta ruta)
        {  
            ruta.Codigo = SqlConnector.executeProcedure("altaRutaAerea", ruta.Origen, ruta.Destino, ruta.PrecioBasePasaje, ruta.PrecioBaseKg, ruta.Habilitada ? 1 : 0);
            if (ruta.Codigo == -1) { return ruta.Codigo; }
            ruta.Servicios.ForEach(servicio => agregarServicio(servicio, ruta.Codigo));
            return ruta.Codigo;
        }

        public static int agregarServicio(String servicio, int codigo) {
            return SqlConnector.executeProcedure("agregar_servicio", servicio, codigo);
        }

        public static int borrarServicio(String servicio, int codigo) {
            return SqlConnector.executeProcedure("borrar_servicio", servicio, codigo);
        }

        public static List<String> getServicios(int codigo)
        {
            return SqlConnector.retrieveList("get_servicios_rutas", "serv_nombre", codigo);
        }
    }
}
