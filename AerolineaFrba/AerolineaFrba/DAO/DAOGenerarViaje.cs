using AerolineaFrba.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.DAO
{
    public static class DAOGenerarViaje
    {
        // metodo para obtener las matriculas de las aeronaves disponbibles
        public static List<String> getAeronavesDisponibles(DateTime salida, DateTime llegada)
        {
            List<String> aeronaves = new List<String>();
            aeronaves = SqlConnector.retrieveDT("get_aeronaves_disponibles", salida, llegada).AsEnumerable().ToList().ConvertAll(x => x.Field<String>("aero_matricula"));
            return aeronaves;
        }

        public static int getRutas(String aeronave, DataGridView dg)
        {
           return SqlConnector.retrieveDT("get_rutas", dg, aeronave);
        }


        public static int generarViaje(String matricula, DateTime llegada, DateTime salida, String codigoRuta)
        {
            return SqlConnector.executeProcedure("create_viaje", matricula, llegada, salida, codigoRuta);
        }
    }
}
