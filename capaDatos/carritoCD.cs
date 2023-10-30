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
    public class carritoCD
    {
        private SqlConnection? _conn;
        private conexion cnx = new conexion();

        public List<carritoCE> ListarCarrito()
        {
            _conn = cnx.Conexion();
            string sql = "sp_listar_productos_carrito";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, _conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@userid", 1);


            DataTable tb_pais = new DataTable();

            adapter.Fill(tb_pais);

            List<carritoCE> carritoCEs = new List<carritoCE>();

            foreach (DataRow row in tb_pais.Rows)
            {
                carritoCE producto = new carritoCE();
                producto.codigo_producto = (int)row["codigo_producto"];
                producto.nombre_producto = (string)row["nombre_producto"];
                producto.precio_producto = (decimal)row["precio_producto"];
                producto.categoria_producto = (string)row["categoria_producto"];
                producto.id_usuario = (int)row["id_usuario"];
                producto.cantidad = (int)row["cantidad"];
                producto.subtotal = (decimal)row["subtotal"];

                carritoCEs.Add(producto);
            }
            return carritoCEs;
        }

        public bool AgregarCarrito(int usuarioId, int productoId, int cantidad)
        {
            _conn = cnx.Conexion();
            _conn.Open();

            string sql = "sp_agregar_producto_carrito";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = usuarioId;
            cmd.Parameters.Add("@prodid", SqlDbType.Int).Value = productoId;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
            
            int rowsAffected = cmd.ExecuteNonQuery();

            _conn.Close();

            return rowsAffected > 0;
        }

        public bool EliminarCarrito(int usuarioId, int productoId)
        {
            _conn = cnx.Conexion();
            _conn.Open();

            string sql = "sp_eliminar_producto_carrito";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = usuarioId;
            cmd.Parameters.Add("@prodid", SqlDbType.Int).Value = productoId;

            int rowsAffected = cmd.ExecuteNonQuery();

            _conn.Close();

            return rowsAffected > 0;
        }

    }
}
