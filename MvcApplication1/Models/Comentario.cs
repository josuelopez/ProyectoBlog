using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Comentarios { get; set; }
        public bool Estado { get; set; }
        public virtual Blog Blog { get; set; }
    }
}