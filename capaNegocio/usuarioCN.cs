using capaDatos;
using capaEntidad;
using System.Data;

namespace capaNegocio
{
    public class usuarioCN
    {
        private usuarioCD cp = new usuarioCD();

        public bool SignIn(usuarioCE cE)
        {
            return cp.signIn(cE);
        }
    }
}