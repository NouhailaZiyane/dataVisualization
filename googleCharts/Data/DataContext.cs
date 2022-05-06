using googleCharts.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace googleCharts.Data
{
    public class DataContext:DbContext
    {
        public DataContext(): base(nameOrConnectionString: "myconnection") { }
        public DbSet<cgeo> cgeo { get; set; }
        public DbSet<dbfiles> files { get; set; }
        public DbSet<grappe> grappe { get; set; }
        public DbSet<menage> menage { get; set; }
        public DbSet<parametrage> parametrage { get; set; }
        public DbSet<profil> profil { get; set; }
        public DbSet<prog> prog { get; set; }
        public DbSet<tablette> tablette { get; set; }






        public System.Data.Entity.DbSet<googleCharts.Models.c3> c3 { get; set; }
    }
}