using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;
using capaComun.cache;

namespace capaPresentacion
{
    public partial class listProductos : UserControl
    {
        public listProductos()
        {
            InitializeComponent();
        }

        public int ProductoId { get; set; }
        public string NombreProducto { get { return lblNombreProducto.Text; } set => lblNombreProducto.Text = value; }
        public string CategoriaProducto { get { return lblCategoriaProducto.Text; } set => lblCategoriaProducto.Text = value; }
        public string PrecioProducto { get { return lblPrecioProducto.Text; } set => lblPrecioProducto.Text = value; }
        public string CantidadProducto { get { return lblCantidadProducto.Text; } set => lblCantidadProducto.Text = value; }

        private void btnEliminarCarrito_Click(object sender, EventArgs e)
        {
            int productoId = ProductoId;
            int usuarioId = (int)userLoginCache.id;

            carritoCN carritoCN = new carritoCN();
            bool result = carritoCN.eliminarCarrito(usuarioId, productoId);

            if (result == true)
            {
                MessageBox.Show("Producto eliminado del carrito");
            } else
            {
                MessageBox.Show("Error al eliminar el producto");
            }
        }

        private void listProductos_Load(object? sender, EventArgs? e)
        {

        }
    }
}
