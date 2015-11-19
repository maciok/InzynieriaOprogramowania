using System.Collections.Generic;

namespace ProjektMVP.Models.Interfaces
{
    public interface IUzytkownikModel
    {
        int ZapiszNowegoUzytkownika(UzytkownikEntity uzytkownik);
        UzytkownikEntity EdytujNowegoUzytkownika(UzytkownikEntity uzytkownik);
        bool WalidujDaneUzytkownika(UzytkownikEntity uzytkownik);
        UzytkownikEntity EdytujKarteKredytowa(UzytkownikEntity uzytkownik);
        List<UzytkownikEntity> PobierzListeUzytkownikow();
        bool WalidujDaneKartyKredytowej(UzytkownikEntity uzytkownik);
    }
}
