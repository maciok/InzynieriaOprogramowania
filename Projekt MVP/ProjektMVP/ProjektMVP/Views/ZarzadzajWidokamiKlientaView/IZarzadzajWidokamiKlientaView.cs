namespace ProjektMVP.Views.ZarzadzajWidokamiKlientaView
{
    using System.Web.Mvc;
    using DTO;

    public interface IZarzadzajWidokamiKlientaView
    {
        ActionResult KliknijPrzyciskDodajUzytkownika();
        ActionResult WyswietlFormularzDodawaniaLubEdytowaniaUzytkownika(UzytkownikDTO dto);
    }
}
