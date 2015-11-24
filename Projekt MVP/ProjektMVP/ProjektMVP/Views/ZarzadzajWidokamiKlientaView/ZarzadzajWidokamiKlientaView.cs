using System.Collections.Generic;

namespace ProjektMVP.Views.ZarzadzajWidokamiKlientaView
{
    using Controllers;
    using Controllers.Interfaces;
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

        public ActionResult KliknijWyswietlListeUzytkownikow()
        {
            throw new System.NotImplementedException();
        }

        public ActionResult WyswietlListeUzytkownikow(List<UzytkownikDTO> list)
        {
            throw new System.NotImplementedException();
        }
    }
}