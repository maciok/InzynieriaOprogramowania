using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektMVP.Models;
using ProjektMVP.Views.WidokiManageraHotelu;

namespace ProjektMVP.Presenters
{
    [RoutePrefix("ZarzadzanieHotelem")]
    public class ZarzadzanieHotelemController : Controller, IZarządzanieHotelem
    {
        private static IFormularzEdycjiParametrówHotelu _formularzEdycjiParametrówHotelu;
        private static IZarzadzanieHotelami _zarzadzanieHotelami;

        public ZarzadzanieHotelemController()
        {
            _formularzEdycjiParametrówHotelu = new FormularzEdycjiParametrówHoteluViewController(this);
            _zarzadzanieHotelami = new ZarzadzanieHotelami();
        }
        
        [Route("EdytujParametryHotelu/{hotelId}")]
        public ActionResult EdytujParametryHotelu(int hotelId)
        {
            IDaneHoteloweModel dane = _zarzadzanieHotelami.PobierzHotel(hotelId);
            return _formularzEdycjiParametrówHotelu.PokażFormularzEdycjiParametrówHotelu(dane);
        }
        
        [Route("ZapiszDaneHotelu")]
        [HttpPost]
        public bool ZapiszDaneHotelu(IDaneHoteloweModel data)
        {
            return _zarzadzanieHotelami.ZapiszHotel(data) ;
        }
    }
}