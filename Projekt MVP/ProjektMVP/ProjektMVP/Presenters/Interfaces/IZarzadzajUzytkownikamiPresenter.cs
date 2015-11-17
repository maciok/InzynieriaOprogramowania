namespace ProjektMVP.Presenters.Interfaces
{
    using DTO;

    public interface IZarzadzajUzytkownikamiPresenter
    {
        int DodajUzytkownika(UzytkownikDTO dto);
        UzytkownikDTO EdytujUzytkownika(UzytkownikDTO dto);
    }
}
