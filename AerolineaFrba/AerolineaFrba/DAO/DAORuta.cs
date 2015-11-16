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

        public static int modificarRuta(int codigo, Model.Ruta ruta)
        {
            int habil = ruta.Habilitada ? 1 : 0;
            return SqlConnector.executeProcedure("modificar_ruta", codigo, ruta.Origen, ruta.Destino, habil, ruta.Servicio,
                 ruta.PrecioBaseKg, ruta.PrecioBasePasaje);
        }

        public static int darDeBaja(Model.Ruta ruta)
        {
            return SqlConnector.executeProcedure("bajaRutaAerea", ruta.Codigo);

        }

        public static bool darDeAlta(Model.Ruta ruta)
        {
            return SqlConnector.executeProcedure("altaRutaAerea", ruta.Origen, ruta.Destino, ruta.Servicio, ruta.PrecioBasePasaje, ruta.PrecioBaseKg, ruta.Habilitada ? 1 : 0) == 1 ? true: false;
        }
    }
}
