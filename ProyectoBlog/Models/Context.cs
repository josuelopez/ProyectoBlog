using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProyectoBlog.Models
{
    

        public class BlogContext : DbContext
        {
            public DbSet<infoBlog> infoBlog { get; set; }
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<blogHome> blogHome { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }

            public BlogContext() : base("BDBlog") { }
        }
    
}