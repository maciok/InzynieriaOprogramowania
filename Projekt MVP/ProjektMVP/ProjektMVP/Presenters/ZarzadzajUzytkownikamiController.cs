namespace ProjektMVP.Presenters
{
    using Views.ZarzadzajWidokamiKlientaView;
    using Models;
    using Models.Interfaces;
    using System.Web.Mvc;
    using DTO;
    using Interfaces;
    
    public class ZarzadzajUzytkownikamiController : Controller, IZarzadzajUzytkownikamiPresenter
    {
        private static IUzytkownikModel uzytkownikModel;
        private static IZarzadzajWidokamiKlientaView zarzadzajWidokamiKlientaView;

        public ZarzadzajUzytkownikamiController()
        {
            uzytkownikModel = new UzytkownikModel();
            zarzadzajWidokamiKlientaView = new ZarzadzajWidokamiKlientaView(this);
        }

        public int DodajUzytkownika(UzytkownikDTO dto)
        {
            return uzytkownikModel.ZapiszNowegoUzytkownika(UzytkownikEntity.MapDtoToEntity(dto));
        }

        public UzytkownikDTO EdytujUzytkownika(UzytkownikDTO dto)
        {
            var edytowanyUzytkownik = uzytkownikModel.EdytujNowegoUzytkownika(UzytkownikEntity.MapDtoToEntity(dto));
            return UzytkownikDTO.MapEntityToDto(edytowanyUzytkownik);
        }
    }
}