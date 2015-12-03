using ProjektMVP.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ProjektMVP.Models;
using ProjektMVP.Models.Interfaces;
using ProjektMVP.DTO;

namespace ProjektMVP.Controllers
{
#pragma warning disable CS0162 // Unreachable code detected

    [RoutePrefix("Rezerwacja")]
    public class DaneRezerwacjiController : Controller, IDaneRezerwacjiPresenter
    {
        private static IPlatnosciModel _platnosc;
        private static IRezerwacjaModel _rezerwacja;

        public DaneRezerwacjiController()
        {
            _platnosc = new PlatnosciModel();
            _rezerwacja = new RezerwacjaModel();
        }

        #region Iteracja1

        public bool ZaksiegujPlatnosc(PlatnoscEntity platnosc)
        {
            throw new NotImplementedException();

            _platnosc.DodajPlatnosc(platnosc);
            return true;
        }

        public string ZapiszDoPliku(PlatnoscEntity platnosc, PlatnoscFormatZapisu format)
        {
            throw new NotImplementedException();

            // Utworz dokument ze wzgledu na format
            if (format == PlatnoscFormatZapisu.FormatTXT) {
                var document = FormatTxt(platnosc);
            } else {
                // inne formaty
            }

            // String bedzie zastapiony typem File w przyszlosci
            return "File()";
        }

        public string FormatTxt(PlatnoscEntity platnosc)
        {
            throw new NotImplementedException();
        }

        public void Drukuj(PlatnoscEntity platnosc)
        {
            //drukowanie...
        }
        #endregion

        #region Iteracja2

        [Route("Extend/{dto.Id}")]
        [HttpGet]
        public ActionResult WyswietlPrzedluzPobyt(RezerwacjaPrzedluzPobytDTO dto)
        {
            return View("FormularzPrzedluzPobyt");
        }

        [Route("Extend/{dto.Id}")]
        [HttpPost]
        public ActionResult PrzedluzPobyt(RezerwacjaPrzedluzPobytDTO dto)
        {
            var result = _rezerwacja.PrzedluzPobyt(dto);
            ViewBag.Success = (Nullable<bool>)result;

            return View("WyswietlKomunikatPrzedluzPobyt");
        }

        #endregion
    }
#pragma warning restore CS0162 // Unreachable code detected
}
