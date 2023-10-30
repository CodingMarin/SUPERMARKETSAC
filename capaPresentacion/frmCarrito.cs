using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaComun.cache;
using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class frmCarrito : Form
    {
        public frmCarrito()
        {
            InitializeComponent();
        }

        private void frmCarrito_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void loadProduct()
        {
            carritoCN carritoCN = new carritoCN();

            List<carritoCE> listaCarrito = carritoCN.ListarCarrito();
            decimal total = 0;

            foreach (var carrito in listaCarrito)
            {
                listProductos listProductos = new listProductos();
                listProductos.ProductoId = carrito.codigo_producto;
                listProductos.NombreProducto = carrito.nombre_producto;
                listProductos.CategoriaProducto = carrito.categoria_producto;
                listProductos.PrecioProducto = carrito.precio_producto.ToString();
                listProductos.CantidadProducto = "PU: " + carrito.cantidad.ToString();
                flPanelCarrito.Controls.Add(listProductos);
                total += carrito.subtotal;
            }
            lblSubtotal.Text = "S/. " + total.ToString();

        }

        private void lblContinuarComprando_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
