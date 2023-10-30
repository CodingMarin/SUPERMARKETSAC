using System.Data.SqlClient;
using System.Configuration;

namespace capaDatos
{
    public class conexionCD
    {
        public class conexion
        {
            public SqlConnection Conexion()
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                return cn;
            }
        }
    }
}