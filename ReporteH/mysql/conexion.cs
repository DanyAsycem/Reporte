using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ReporteH.mysql
{
    class conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            string connectionString = "datasource=206.189.167.218;port=3306;username=remoto;password=Re-123456789;database=REPORTEH";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            return databaseConnection;
        }



    }
}
