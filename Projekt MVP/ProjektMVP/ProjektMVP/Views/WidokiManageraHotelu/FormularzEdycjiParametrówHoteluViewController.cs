using ProjektMVP.Models;
using System.Web.Mvc;
using ProjektMVP.Models.Interfaces;
using ProjektMVP.Controllers;

namespace ProjektMVP.Views.WidokiManageraHotelu
{
    public class FormularzEdycjiParametrówHoteluViewController : Controller, IFormularzEdycjiParametrówHotelu
    {
        private static IZarządzanieHotelem _zarządzanieHotelemPresenter;

        public FormularzEdycjiParametrówHoteluViewController()
        {

        }

        public FormularzEdycjiParametrówHoteluViewController(IZarządzanieHotelem presenter)
        {
            _zarządzanieHotelemPresenter = presenter;
        }

        public ActionResult PokażFormularzEdycjiParametrówHotelu(IDaneHoteloweModel dane)
        {
            return View("~/Views/WidokiManageraHotelu/FormularzEdycjiParametrówHotelu.cshtml", dane);
        }

        [HttpPost]
        public ActionResult ZapiszDaneHotelu(DaneHoteloweModel data)
        {
            if (_zarządzanieHotelemPresenter.ZapiszDaneHotelu(data))
            {
                return RedirectToAction("Index", "Home", new { Message = "Zapisano!" } );
            }
            else
            {
                return RedirectToAction("Index", "Home", new { Message = "Nie można zapisać zmian!" } );
            }
        }


        public ActionResult PokażFormularzOdblokowaniaPokoju(IPokojHotelowyModel dane)
        {
            return View("~/Views/WidokiManageraHotelu/FormularzOdblokowaniaPokojuView.cshtml", dane);
        }

        public ActionResult PokażFormularzZablokowaniaPokoju(IPokojHotelowyModel dane)
        {
            return View("~/Views/WidokiManageraHotelu/FormularzZablokowaniaPokojuView.cshtml", dane);
        }

        [HttpPost]
        public ActionResult OdblokujPokoj(string Odblokuj, PokojHotelowy data)
        {
            if (!string.IsNullOrEmpty(Odblokuj))
            {
                data.Status = StatusPokoju.Odblokowany;
                if (_zarządzanieHotelemPresenter.ZapiszPokoj(data))
                {
                    return RedirectToAction("Index", "Home", new { Message = "Odblokowano pokój: " + data.Nazwa });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { Message = "Nie można odblokować pokoju: " + data.Nazwa });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { Message = "Anulowano i przekierowano do listy pokoi!" });
            }
        }

        [HttpPost]
        public ActionResult ZablokujPokoj(string Zablokuj, PokojHotelowy data)
        {
            if (!string.IsNullOrEmpty(Zablokuj))
            {
                data.Status = StatusPokoju.Zablokowany;
                if (_zarządzanieHotelemPresenter.ZapiszPokoj(data))
                {
                    return RedirectToAction("Index", "Home", new { Message = "Zablokowano pokój: " + data.Nazwa });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { Message = "Nie można Zablokować pokoju: " + data.Nazwa });
                }

            }
            else
            {
                return RedirectToAction("Index", "Home", new { Message = "Anulowano i przekierowano do listy pokoi!" });
            }
        }
    }
}
