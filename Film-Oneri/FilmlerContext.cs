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
       

    }
}
