using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
     public class BlogContext : DbContext
        {
            public DbSet<Blog> Blog { get; set; }
            public DbSet<Comentario> Comentario { get; set; }
            

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }

            public BlogContext() : base("BDBlog")
            { }

            public DbSet<Usuario> Usuarios { get; set; }
        }

}