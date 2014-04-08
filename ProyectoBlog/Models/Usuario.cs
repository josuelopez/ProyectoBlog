using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBlog.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public string biografia { get; set; }
        public string redesSociales { get; set; }
    }
}