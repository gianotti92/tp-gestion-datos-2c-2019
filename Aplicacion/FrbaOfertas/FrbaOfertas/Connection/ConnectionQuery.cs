using System.Data;
using System.Data.SqlClient;

namespace FrbaOfertas.Connection
{
    public class ConnectionQuery
    {
        public static SqlConnection conexion = null;

        static ConnectionQuery() { 
        }

        public static void cerrarConexion()
        {
            conexion.Close();
        }

        public static void abrirConexion()
        {
            conexion.Open();
        }

        public static SqlConnection Instance()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            }
            return conexion;
        }
       
    }
}