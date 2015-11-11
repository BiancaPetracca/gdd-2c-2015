using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AerolineaFrba.DAO
{
    public static class DAOCompra
    {

        // lista todas las ciudades que hay y las agrega 
        public static List<Ciudad> listCiudades()
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            foreach (DataRow row in SqlConnector.retrieveDataTable("get_ciudades").Rows)
            {
                ciudades.Add(new Ciudad(row["ciu_nombre"].ToString()));
            }
            return ciudades;
        }


    }
}
