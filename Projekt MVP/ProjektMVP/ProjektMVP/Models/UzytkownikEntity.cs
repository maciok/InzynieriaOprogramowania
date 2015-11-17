namespace ProjektMVP.Models
{
    using DTO;

    public class UzytkownikEntity
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int? KartaKredytowaId { get; set; }

        public static UzytkownikEntity MapDtoToEntity(UzytkownikDTO dto)
        {
            return new UzytkownikEntity
            {
                Id = dto.Id ?? 0,
                Imie = dto.Imie,
                Nazwisko = dto.Nazwisko,
                KartaKredytowaId = dto.Karta?.KartaKredytowaId 
            };
        }
    }
}