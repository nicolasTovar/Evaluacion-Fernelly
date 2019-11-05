using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Requerimiento
{
    public class conexion
    {
        private static SqlConnection conex;
        private conexion()
        {

        }
        public static SqlConnection obtener()
        {
            if (conex == null)
            {
                conex = new SqlConnection(Properties.Settings.Default.conectar);
                conex.Open();
            }
            return conex;
        }
    }
}