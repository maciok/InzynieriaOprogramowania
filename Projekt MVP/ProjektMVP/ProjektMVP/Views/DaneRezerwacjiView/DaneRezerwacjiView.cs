using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ProjektMVP.Models;
using ProjektMVP.Presenters.Interfaces;

namespace ProjektMVP.Views.DaneRezerwacjiView
{
#pragma warning disable CS0162 // Unreachable code detected

    public class DaneRezerwacjiView : Controller, IDaneRezerwacjiView
    {
        private IDaneRezerwacjiPresenter _presenter;

        public DaneRezerwacjiView(IDaneRezerwacjiPresenter presenter)
        {
            this._presenter = presenter;
        }

        public ActionResult KliknijWygenerujRachunek(RezerwacjaEntity rezerwacja)
        {
            throw new NotImplementedException();

            return View("WidokEdycjiPlatnosci");
        }

        public ActionResult KliknijZapiszPlatnosc(PlatnoscEntity platnosc)
        {
            throw new NotImplementedException();

            return View("WidokPodsumowaniaPlatnosci");
        }

        public ActionResult KliknijZaksiegujPlatnosc(PlatnoscEntity platnosc)
        {
            throw new NotImplementedException();

            _presenter.ZaksiegujPlatnosc(platnosc);
            return View("OK/Blad");
        }

        public ActionResult KliknijZapiszDoPliku(PlatnoscZapiszDoPlikuViewModel input)
        {
            throw new NotImplementedException();

            _presenter.ZapiszDoPliku(input.Platnosc, input.Format);
            return View("File");

            // Wersja w przyszlosci
            // return _presenter.ZapiszDoPliku(input.Platnosc, input.Format);
        }
    }
#pragma warning restore CS0162 // Unreachable code detected

}
