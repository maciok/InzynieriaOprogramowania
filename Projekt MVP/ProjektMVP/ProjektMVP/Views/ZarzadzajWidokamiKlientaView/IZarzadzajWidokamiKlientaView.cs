namespace ProjektMVP.Views.ZarzadzajWidokamiKlientaView
{
    using System.Web.Mvc;
    using DTO;
    using System.Collections.Generic;

    public interface IZarzadzajWidokamiKlientaView
    {

        ActionResult KliknijWyswietlListeUzytkownikow();
        ActionResult WyswietlListeUzytkownikow(List<UzytkownikDTO> list);
    }
}
