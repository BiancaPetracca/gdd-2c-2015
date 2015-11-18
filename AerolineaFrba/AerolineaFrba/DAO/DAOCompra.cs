using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AerolineaFrba.Model;

namespace AerolineaFrba.DAO
{
    public static class DAOCompra
    {

        // lista todas las ciudades que hay y las agrega 
        public static List<Ciudad> listCiudades()
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            foreach (DataRow row in SqlConnector.retrieveDT("get_ciudades").Rows)
            {
                ciudades.Add(new Ciudad(row["ciu_nombre"].ToString()));
            }
            return ciudades;
        }

        public static List<String> listarCiudades()
        {
            List<String> ciudades = new List<String>();
            foreach (DataRow row in SqlConnector.retrieveDT("get_ciudades").Rows)
            {
                ciudades.Add(row["ciu_nombre"].ToString());
            }
            return ciudades;
        }
    }
}
