namespace ProjektMVP.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class UzytkownikModel : IUzytkownikModel
    {
        public int ZapiszNowegoUzytkownika(UzytkownikEntity uzytkownik)
        {
            if(WalidujDaneUzytkownika(uzytkownik))
                return 1;
            return 0;
        }

        public UzytkownikEntity EdytujNowegoUzytkownika(UzytkownikEntity uzytkownik)
        {
            if (WalidujDaneUzytkownika(uzytkownik))
                return new UzytkownikEntity();
            else
                return null;
        }

        public bool WalidujDaneUzytkownika(UzytkownikEntity uzytkownik)
        {
            return true;
        }

        public bool EdytujKarteKredytowa(UzytkownikEntity uzytkownik)
        {
            return WalidujDaneKartyKredytowej(uzytkownik);
        }

        public List<UzytkownikEntity> PobierzListeUzytkownikow()
        {
            return new List<UzytkownikEntity>();
        }

        public bool WalidujDaneKartyKredytowej(UzytkownikEntity uzytkownik)
        {
            return true;
        }
    }
}