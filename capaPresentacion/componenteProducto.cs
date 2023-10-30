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
    public partial class componenteProducto : UserControl
    {

        public componenteProducto()
        {
            InitializeComponent();
        }

        public int ProductoId { get; set; }
        public string NombreProducto { get { return lblNombreProducto.Text; } set => lblNombreProducto.Text = value; }
        public string EstadoProducto { get { return lblCategoriaProducto.Text; } set => lblCategoriaProducto.Text = value; }
        public string PrecioProducto { get { return lblPrecioProducto.Text; } set => lblPrecioProducto.Text = value; }
        public string StockProducto { get { return lblStockProducto.Text; } set => lblStockProducto.Text = value; }
        public string CantidadProducto { get { return txtCantidadProducto.Text; } set => txtCantidadProducto.Text = value; }
        public string CategoriaProducto { get { return lblCategoriaProducto.Text; } set => lblCategoriaProducto.Text = value; }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            if(txtCantidadProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingresa una cantidad");
                txtCantidadProducto.Focus();
                return;
            }
            if (userLoginCache.id == null)
            {
                MessageBox.Show("Debe logearse primero");
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
            else
            {

                txtCantidadProducto.Enabled = true;
                int productoId = ProductoId;
                int cantidad = int.Parse(CantidadProducto);
                int userid = (int)userLoginCache.id;

                carritoCN carritoCN = new carritoCN();
                bool result = carritoCN.agregarCarrito(userid, productoId, cantidad);

                if(result == true)
                {
                    txtCantidadProducto.Text = "";
                    MessageBox.Show("Producto agregado satisfactoriamente");
                }

            }
        }
    }
}
