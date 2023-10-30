using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaComun.cache
{
    public class productosCache
    {
        public int cod { get; set; }
        public string? nombre_producto { get; set; }
        public decimal? precio { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public string? estado_fisico { get; set; }
        public int stock { get; set; }
        public string? categoria { get; set; }
    }
}
