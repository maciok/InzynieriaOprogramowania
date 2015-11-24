namespace ProjektMVP.Models
{
    using DTO;

    public static class UzytkownikMapper
    {
        public static UzytkownikEntity MapDtoToEntity(UzytkownikDTO dto)
        {
            var uzytkownik = new UzytkownikEntity
            {
                Imie = dto.Imie,
                Nazwisko = dto.Nazwisko,
                KartaKredytowaId = dto.Karta?.KartaKredytowaId,
                Login = dto.Login,
                PermissionsId = dto.PermissionsId,
                HotelId = dto.HotelId
            };

            if (dto.Id.HasValue)
                uzytkownik.Id = dto.Id.Value;

            return uzytkownik;
        }

        public static UzytkownikDTO MapEntityToDto(UzytkownikEntity entity)
        {
            return new UzytkownikDTO
            {
                Id = entity.Id,
                Imie = entity.Imie,
                Nazwisko = entity.Nazwisko,
                Login = entity.Login,
                HotelId = entity.HotelId,
                PermissionsId = entity.PermissionsId,
                Karta = entity.KartaKredytowaId.HasValue ?
                    new KartaKredytowaDTO
                    {
                        KartaKredytowaId = entity.KartaKredytowaId.Value
                    } : null
            };
        }
    }
}