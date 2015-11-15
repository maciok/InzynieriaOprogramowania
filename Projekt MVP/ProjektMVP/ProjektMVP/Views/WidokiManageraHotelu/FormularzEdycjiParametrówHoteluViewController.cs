using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using ProjektMVP.Models;
using System.Web.Mvc;
using ProjektMVP.Presenters;

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
    }
}
