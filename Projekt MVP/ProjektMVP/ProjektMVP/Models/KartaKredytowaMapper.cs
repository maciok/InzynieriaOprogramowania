namespace ProjektMVP.Models
{
    using DTO;

    public static class KartaKredytowaMapper
    {
        public static KartaKredytowaDTO MapEntityToDto(KartaKredytowaEntity entity)
        {
            return new KartaKredytowaDTO
            {
                KartaKredytowaId = entity.KartaKredytowaId
            };
        }

        public static KartaKredytowaEntity MapDtoToEntity(KartaKredytowaDTO dto)
        {
            return new KartaKredytowaEntity
            {
                KartaKredytowaId = dto.KartaKredytowaId
            };
        }
    }
}