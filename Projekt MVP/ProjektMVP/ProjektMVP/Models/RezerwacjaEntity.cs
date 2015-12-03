using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVP.Models
{
    public class RezerwacjaEntity
    {
        public int RezerwacjaId { get; set; }
        DateTime DataOd { get; set; }
        DateTime DataDo { get; set; }
    }

    public class RezerwacjaContext : DbContext
    {
        public RezerwacjaContext()
        {
            Database.SetInitializer<RezerwacjaContext>(null);
        }

        public DbSet<RezerwacjaEntity> Uzytkownicy { get; set; }
    }
}
