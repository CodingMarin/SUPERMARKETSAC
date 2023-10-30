using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static capaDatos.conexionCD;

namespace capaDatos
{
    public class productoCD
    {
        private SqlConnection? _conn;

        private conexion cnx = new conexion();

        public SqlDataReader listarProductos()
        {
            _conn = cnx.Conexion();
            _conn.Open();

            string sql = "SELECT * FROM producto";
            var command = new SqlCommand(sql, _conn);
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }
    }
}
