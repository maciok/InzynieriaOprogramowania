namespace ProjektMVP.Models
{
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
    }
}