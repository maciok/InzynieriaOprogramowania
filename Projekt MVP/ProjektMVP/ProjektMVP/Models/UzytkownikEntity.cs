namespace ProjektMVP.Models
{
    using System.Data.Entity;

    public class UzytkownikEntity
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public int PermissionsId { get; set; }
        public int HotelId { get; set; }
        public int? KartaKredytowaId { get; set; } 
    }

    public class UzytkownikContext : DbContext
    {
        public UzytkownikContext()
        {
            Database.SetInitializer<UzytkownikContext>(null);
        }

        public DbSet<UzytkownikEntity> Uzytkownicy { get; set; }
    }
}