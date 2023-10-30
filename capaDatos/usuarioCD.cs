using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static capaDatos.conexionCD;
using capaComun.cache;

namespace capaDatos
{
    public class usuarioCD
    {
        private SqlConnection? _conn;
        private conexion cnx = new conexion();

        public bool signIn(usuarioCE cE)
        {
            _conn = cnx.Conexion();
            _conn.Open();

            string sql = "SELECT * FROM usuarios WHERE username = @username AND password = @password";
            SqlCommand command = new SqlCommand(sql, _conn);

            command.Parameters.AddWithValue("@username", cE.username);
            command.Parameters.AddWithValue("@password", cE.password);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read()){
                    userLoginCache.id = reader.GetInt32(0);
                    userLoginCache.nombre = reader.GetString(1);
                    userLoginCache.apellido = reader.GetString(2);
                    userLoginCache.username = reader.GetString(3);
                    userLoginCache.rol_id = reader.GetString(5);
                }
                return true;
            } else
            {
                return false;
            }
        }
    }
}
