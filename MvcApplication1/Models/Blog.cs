using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public DateTime fecha { get; set; }
        public string contenido { get; set; }
        
    }
}