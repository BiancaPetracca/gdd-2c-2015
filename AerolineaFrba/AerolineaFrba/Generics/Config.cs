using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Data;
using AerolineaFrba.DAO;

namespace AerolineaFrba.Generics
{
    public static class Config
    {
        public static DateTime DateToday { get { return Convert.ToDateTime(ConfigurationManager.AppSettings.Get("dateToday")); } }


        public static String[] Funcionalidades = {"abm_ruta", "abm_aeronave", "canje_millas", "compra", "consulta_millas", "devolucion"
                                         , "generar_viaje", "estadisticas", "login", "registro_llegada", "registro_usuario"};

        public static void SetDateInDB(){
            SqlConnector.executeProcedure("set_date", DateToday);

        }
        // seteamos aca la terminal desde la  que se accede porque consideramos que es algo global y que tienen acceso muchos
        // forms de la compra.
        public static int Terminal { get ; set; }
    }
 
}

// 0 RUTA // 1 AERONAVE // 2 CANJE MILLAS // 3 COMPRA // 4 CONSULTA MILLAS // 5 DEVOLUCION
// 6 GENERAR VIAJE // 7 ESTADISTICAS // 8 LOGIN // 9 REGISTRO LLEGADA // 10 REGISTRO USUARIO
