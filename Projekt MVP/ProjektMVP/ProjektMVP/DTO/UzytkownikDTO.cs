namespace ProjektMVP.DTO
{
    using Models;

    public class UzytkownikDTO
    {
        public int? Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public KartaKredytowaDTO Karta { get; set; }

        public static UzytkownikDTO MapEntityToDto(UzytkownikEntity entity)
        {
            return new UzytkownikDTO
            {
                Id = entity.Id,
                Imie = entity.Imie,
                Nazwisko = entity.Nazwisko,
                Karta = entity.KartaKredytowaId.HasValue ?
                    new KartaKredytowaDTO
                    {
                        KartaKredytowaId =  entity.KartaKredytowaId.Value
                    } : null
            };
        }
    }
}