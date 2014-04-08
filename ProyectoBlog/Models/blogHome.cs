using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBlog.Models
{
    public class blogHome
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string fecha { get; set; }
        public string comentario { get; set; }
    }
}