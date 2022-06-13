using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ArmyWebSite.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<AnaSayfa> Anasayfas {get; set;}
        public DbSet<Hakkimda> Hakkimdas { get; set; }
        public DbSet<Projeler> Projelers { get; set; }
        public DbSet<Galeri> Galeris { get; set; }
        public DbSet<İletisim> iletisims { get; set; }

    }
}