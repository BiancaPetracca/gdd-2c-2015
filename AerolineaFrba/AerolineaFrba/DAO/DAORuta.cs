using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.DAO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AerolineaFrba.DAO
{
    public static class DAORuta
    {

        public static List<String> getAllCiudad(String procedure)
        {
            List<String> ciudades = new List<String>();
            DataTable dt = SqlConnector.retrieveDataTable(null, procedure, null);

            foreach (DataRow dr in dt.Rows)
            {
                ciudades.Add(Convert.ToString(dr));
            }

            return ciudades;
        }

    }
}
