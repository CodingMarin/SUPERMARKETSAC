using capaNegocio;
using capaEntidad;
using capaComun.cache;
using System.Data.SqlClient;
using static capaDatos.conexionCD;
using System.Data;

namespace capaPresentacion
{
    public partial class supermarketMDI : Form
    {
        private Thread? realtimeData;
        private SqlConnection? _conn;
        private conexion cnx = new conexion();

        public supermarketMDI()
        {
            InitializeComponent();
            realtimeData = new Thread(updateThread);
            realtimeData.Start();
        }

        private void updateThread()
        {
            while (true)
            {

                this.Invoke((MethodInvoker)delegate
                {
                    //Si hay usuario logeado muestra los datos y
                    //oculta la opcion de autenticarse
                    if (userLoginCache.username != null)
                    {
                        lblUsername.Visible = true;
                        lblUsername.Text = userLoginCache.nombre;
                        lblBienvenido.Visible = true;
                        toolAuth.Visible = false;
                        
                    }
                    else
                    {
                        toolAuth.Visible = true;
                        lblBienvenido.Visible = false;
                        lblUsername.Visible = false;
                    }
                });
                Thread.Sleep(1000);

            }
        }

        private void MostrarProductos(FlowLayoutPanel contenedor)
        {
            productoCE productoCE = new productoCE();

            _conn = cnx.Conexion();
            _conn.Open();

            string sql = "SELECT * FROM productos";
            var command = new SqlCommand(sql, _conn);
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int cod = productoCE.cod = (int)reader["id"];
                string nombre = productoCE.nombre_producto = (string)reader["nombre"];
                decimal precio = productoCE.precio = (decimal)reader["precio"];
                string estado = productoCE.estado_fisico = (string)reader["estado_fisico"];
                int stock = productoCE.stock = (int)reader["stock"];
                string categoria = productoCE.categoria = (string)reader["categoria"];

                componenteProducto componente = new componenteProducto();
                componente.ProductoId = cod;
                componente.NombreProducto = nombre;
                componente.PrecioProducto = "S/. " + precio;
                componente.StockProducto = "Stock: " + stock.ToString();
                componente.CategoriaProducto = categoria;

                contenedor.Controls.Add(componente);
            }
            _conn.Close();
        }


        private void supermarketMDI_Load(object sender, EventArgs e)
        {
            MostrarProductos(flowLayoutPanel1);
        }

        private void toolLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = frmLogin.ObtenerInstancia();
            frm.Show();
        }

        private void carritoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(userLoginCache.id != null)
            {
                frmCarrito frmCarrito = new frmCarrito();
                frmCarrito.Show();
            } else
            {
                MessageBox.Show("No tienes productos en tu carrito");
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}