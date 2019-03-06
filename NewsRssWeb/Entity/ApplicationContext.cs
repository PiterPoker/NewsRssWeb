using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewsRssWeb.Entity
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        { }

        public DbSet<News> News { get; set; }
        public DbSet<TuningGenerator> TuningGenerators { get; set; }
        public DbSet<Generator> Generators { get; set; }       
    }
}