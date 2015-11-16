using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Data;

namespace AerolineaFrba.Generics
{
    public static class Config
    {
        public static DateTime DateToday { get { return Convert.ToDateTime(ConfigurationManager.AppSettings.Get("dateToday")); } }
    }
}
