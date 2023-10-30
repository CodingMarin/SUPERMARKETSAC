using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class carritoCE
    {
        public int codigo_producto { get; set; }
        public string? nombre_producto { get; set; }
        public decimal precio_producto { get; set; }
        public string? categoria_producto { get; set; }
        public int id_usuario { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
    }
}
