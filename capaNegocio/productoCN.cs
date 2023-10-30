using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class productoCN
    {
        private productoCD prodCP = new productoCD();

        public SqlDataReader mostrarProductos()
        {
            return prodCP.listarProductos();
        }
    }
}
