namespace ProjektMVP.DTO
{
    public class UzytkownikDTO
    {
        public int? Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public int HotelId { get; set; }
        public int PermissionsId { get; set; }
        public KartaKredytowaDTO Karta { get; set; }
    }
}