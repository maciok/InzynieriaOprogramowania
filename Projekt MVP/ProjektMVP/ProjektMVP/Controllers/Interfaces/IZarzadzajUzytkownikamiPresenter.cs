namespace ProjektMVP.Controllers.Interfaces
{
    using System.Web.Mvc;
    using DTO;
    using System.Collections.Generic;

    public interface IZarzadzajUzytkownikamiPresenter
    {
        #region Robert Witkowski
        int DodajUzytkownika(UzytkownikDTO dto);
        UzytkownikDTO EdytujUzytkownika(UzytkownikDTO dto);
        UzytkownikDTO PobierzUzytkownika(int uzytkownikId);
        bool ZawiesUzytkownika(int uzytkownikId);
        bool WyslijProsbeOUsuniecieKonta(int uzytkownikId, string opis);

        ActionResult WyswietlFormularzDodawaniaLubEdytowaniaUzytkownika(UzytkownikDTO dto);
        ActionResult DodajLubEdytujUzytkownik(UzytkownikDTO dto);
        ActionResult WyswietlInformacjeOKoncie(int uzytkownikId);
        ActionResult ZawiesUzytkownikaButton(int uzytkownikId);
        ActionResult WyswietlFormularzProsbyOUsuniecieKonta(int uzytkownikId, string opis);
        #endregion

        UzytkownikDTO EdytujKarteKredytowa(UzytkownikDTO u);
        List<UzytkownikDTO> WezListeUzytkownikow();
    }
}
