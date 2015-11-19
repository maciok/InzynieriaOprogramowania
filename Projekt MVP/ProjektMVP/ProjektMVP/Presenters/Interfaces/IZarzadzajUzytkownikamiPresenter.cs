namespace ProjektMVP.Presenters.Interfaces
{
    using DTO;
    using System.Collections.Generic;

    public interface IZarzadzajUzytkownikamiPresenter
    {
        int DodajUzytkownika(UzytkownikDTO dto);
        UzytkownikDTO EdytujUzytkownika(UzytkownikDTO dto);
        UzytkownikDTO EdytujKarteKredytowa(UzytkownikDTO u);
        List<UzytkownikDTO> WezListeUzytkownikow();
    }
}
