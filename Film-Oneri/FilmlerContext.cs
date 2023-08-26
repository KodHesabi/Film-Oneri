using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Oneri
{
    class FilmlerContext:DbContext
    {
        public DbSet<Gerilim> Gerilim { get; set; }

        public DbSet<Korku> Korku { get; set; }

        public DbSet<Savaş> Savaş { get; set; }

        public DbSet<Fantastik> Fantastik { get; set; }

        public DbSet<BilimKurgu> BilimKurgu { get; set; }

        public DbSet<Macera> Macera { get; set; }

        public DbSet<Komedi> Komedi { get; set; }


    }
}
