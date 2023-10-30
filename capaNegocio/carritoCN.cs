using capaEntidad;
using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class carritoCN
    {
        carritoCD carrito = new carritoCD();
        public List<carritoCE> ListarCarrito()
        {
            return carrito.ListarCarrito();
        }
        public bool agregarCarrito(int userid, int productid, int cantidad)
        {
            return carrito.AgregarCarrito(userid, productid, cantidad);
        }
        public bool eliminarCarrito(int userid, int productid)
        {
            return carrito.EliminarCarrito(userid, productid);
        }
    }
}
