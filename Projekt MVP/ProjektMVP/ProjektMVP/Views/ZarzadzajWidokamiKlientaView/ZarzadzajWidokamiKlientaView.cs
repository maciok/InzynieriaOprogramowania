namespace ProjektMVP.Views.ZarzadzajWidokamiKlientaView
{
    using Presenters;
    using Presenters.Interfaces;
    using System.Web.Mvc;
    using DTO;

    public class ZarzadzajWidokamiKlientaView : Controller, IZarzadzajWidokamiKlientaView
    {
        private readonly IZarzadzajUzytkownikamiPresenter presenter;

        public ZarzadzajWidokamiKlientaView()
        {
            presenter = new ZarzadzajUzytkownikamiController();
        }

        public ZarzadzajWidokamiKlientaView(IZarzadzajUzytkownikamiPresenter presenter)
        {
            this.presenter = presenter;
        }

        public ActionResult KliknijPrzyciskDodajUzytkownika()
        {
            return View("Error");
        }

        public ActionResult WyswietlFormularzDodawaniaLubEdytowaniaUzytkownika(UzytkownikDTO dto)
        {
            if (dto.Id.HasValue)
                presenter.EdytujUzytkownika(dto);
            else
                presenter.DodajUzytkownika(dto);

            return View("Error");
        }
    }
}