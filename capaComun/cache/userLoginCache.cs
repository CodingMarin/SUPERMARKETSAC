using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaComun.cache
{
    public static class userLoginCache
    {
        public static int? id {get; set;}
        public static string? nombre { get; set; }
        public static string? apellido { get; set; }
        public static string? username { get; set; }
        public static string? rol_id { get; set;}
    }
}
