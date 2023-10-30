using capaEntidad;
using capaNegocio;
namespace capaPresentacion
{
    public partial class frmLogin : Form
    {
        /*
         *Instancia capa entidad usuario/negocio
         */
        usuarioCE entidadUsuario = new usuarioCE();
        usuarioCN entidadNegocio = new usuarioCN();

        /*
         *Patron singleton
         */
        private static frmLogin? instancia;
        private static readonly object bloqueo = new object();

        public static frmLogin ObtenerInstancia()
        {
            if (instancia == null)
            {
                lock (bloqueo)
                {
                    if (instancia == null)
                    {
                        instancia = new frmLogin();
                    }
                }
            }
            return instancia;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            entidadUsuario.username = txtUsername.Text;
            entidadUsuario.password = txtPassword.Text;

            if (txtUsername.Text == string.Empty)
            {

                MessageBox.Show("Ingresa un usuario");
                txtUsername.Focus();
                return;

            }
            else if (txtPassword.Text == string.Empty)
            {

                MessageBox.Show("Ingresa una contraseña");
                txtPassword.Focus();
                return;

            }

            bool login = entidadNegocio.SignIn(entidadUsuario);

            if (login == true)
            {
                MessageBox.Show("Bienvenido: " + entidadUsuario.username);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
