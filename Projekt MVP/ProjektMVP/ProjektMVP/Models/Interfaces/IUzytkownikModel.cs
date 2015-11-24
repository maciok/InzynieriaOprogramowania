﻿namespace ProjektMVP.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IUzytkownikModel
    {
        #region Robert Witkowski
        //Iteracja 1
        int ZapiszNowegoUzytkownika(UzytkownikEntity uzytkownik);
        UzytkownikEntity EdytujNowegoUzytkownika(UzytkownikEntity uzytkownik);
        bool WalidujDaneUzytkownika(UzytkownikEntity uzytkownik);
        //Iteracja 2
        UzytkownikEntity PobierzUzytkownika(int uzytkownikId);
        bool ZawiesUzytkownika(int uzytkownikId);
        //Iteracja 3
        bool WyslijProsbeOUsuniecieKonta(int uzytkownikId, string opis);
        #endregion

        UzytkownikEntity EdytujKarteKredytowa(UzytkownikEntity uzytkownik);
        List<UzytkownikEntity> PobierzListeUzytkownikow();
        bool WalidujDaneKartyKredytowej(UzytkownikEntity uzytkownik);
    }
}
