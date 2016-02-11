using System.Web.Mvc;
using ProjektMVP.DTO;

namespace ProjektMVP.Views.ZarzadzajUzytkownikami
{
    public interface IZarzadzajUzytkownikamiView
    {
        ActionResult WyswieltFormularzZmianyStatusuUzytkownika(UzytkownikDTO dto);
        ActionResult KliknijPrzyciskZmianyStatusu();
    }
}