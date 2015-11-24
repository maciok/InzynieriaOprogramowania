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
            return View("Error");
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
    }
}
