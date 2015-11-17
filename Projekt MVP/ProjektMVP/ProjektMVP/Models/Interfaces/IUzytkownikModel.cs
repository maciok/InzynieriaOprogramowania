namespace ProjektMVP.Models.Interfaces
{
    public interface IUzytkownikModel
    {
        int ZapiszNowegoUzytkownika(UzytkownikEntity uzytkownik);
        UzytkownikEntity EdytujNowegoUzytkownika(UzytkownikEntity uzytkownik);
        bool WalidujDaneUzytkownika(UzytkownikEntity uzytkownik);
    }
}
