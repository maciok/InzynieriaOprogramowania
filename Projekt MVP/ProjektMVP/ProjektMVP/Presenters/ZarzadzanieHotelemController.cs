using System.Web.Mvc;
using ProjektMVP.DTO;
using ProjektMVP.Models;
using ProjektMVP.Models.Interfaces;
using ProjektMVP.Views.WidokiManageraHotelu;

namespace ProjektMVP.Presenters
{
    [RoutePrefix("ZarzadzanieHotelem")]
    public class ZarzadzanieHotelemController : Controller, IZarządzanieHotelem
    {
        private DaneHoteloweDB db;
        private static IFormularzEdycjiParametrówHotelu _formularzEdycjiParametrówHotelu;
        private static IZarzadzanieHotelami _zarzadzanieHotelami;
        private static IZarządzanieHotelem _zarządzanieHotelem;

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

        [Route("ZapiszPokojDoHotelu")]
        [HttpPost]
        public void DodajPokojDoHotelu(IPokojHotelowyModel pokoj)
        {
            db.PokojeHotelowe.Add(pokoj);
            _zarządzanieHotelem.DodajPokojDoHotelu(pokoj);
        }

        public void EdytujParametryPokoju(int id, IPokojHotelowyModel pokoj)
        {
            _zarządzanieHotelem.EdytujParametryPokoju(id, pokoj);
        }

        public IPokojHotelowyModel WyszukajPokoj(int id)
        {
            return _zarządzanieHotelem.WyszukajPokoj(id);
        }

        public ISalaKonferencyjnaModel WyszukaSalaKonferencyjna(int id)
        {
            return _zarządzanieHotelem.WyszukaSalaKonferencyjna(id);
        }

        public IDaneHoteloweModel WyszukajHotel(int id)
        {
            return _zarzadzanieHotelami.PobierzHotel(id);
        }

        public void DodajHotel(IDaneHoteloweModel daneHotelowe)
        {
            _zarzadzanieHotelami.DodajHotel(daneHotelowe);
        }
    }
}