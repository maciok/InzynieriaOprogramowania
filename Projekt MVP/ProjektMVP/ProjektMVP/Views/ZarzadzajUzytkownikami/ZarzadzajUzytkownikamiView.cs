using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ProjektMVP.Controllers;
using ProjektMVP.Controllers.Interfaces;
using ProjektMVP.DTO;
using ProjektMVP.Views.ZarzadzajWidokamiKlientaView;

namespace ProjektMVP.Views.ZarzadzajUzytkownikami
{
    public class ZarzadzajUzytkownikamiView : Controller, IZarzadzajWidokamiKlientaView
    {
        private readonly IZarzadzajUzytkownikamiPresenter presenter;

        public ZarzadzajUzytkownikamiView()
        {
            presenter = new ZarzadzajUzytkownikamiController();
        }

        public ZarzadzajUzytkownikamiView(IZarzadzajUzytkownikamiPresenter presenter)
        {
            this.presenter = presenter;
        }

        public ActionResult KliknijWyswietlListeUzytkownikow()
        {
            throw new NotImplementedException();
        }

        public ActionResult WyswietlListeUzytkownikow(List<UzytkownikDTO> list)
        {
            throw new NotImplementedException();
        }
    }
}