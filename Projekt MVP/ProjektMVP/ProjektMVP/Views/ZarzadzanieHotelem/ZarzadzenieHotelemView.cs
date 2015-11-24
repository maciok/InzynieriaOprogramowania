using System.Web.Mvc;
using ProjektMVP.Models.Interfaces;
using ProjektMVP.Controllers;

namespace ProjektMVP.Views.ZarzadzanieHotelem
{
    class ZarzadzenieHotelemView
    {
        private static ZarzadzanieHotelemController zarzadzanieHotelemController = new ZarzadzanieHotelemController();

        public IDaneHoteloweModel PobierzHotel(int hotelID)
        {
            return zarzadzanieHotelemController.WyszukajHotel(hotelID);
        }

        public ActionResult EdytujParametryHotelu(int hotelId)
        {
            return zarzadzanieHotelemController.EdytujParametryHotelu(hotelId);
        }

        public bool ZapiszDaneHotelu(IDaneHoteloweModel data)
        {
            return zarzadzanieHotelemController.ZapiszDaneHotelu(data);
        }

        public void DodajPokojDoHotelu(IPokojHotelowyModel pokoj)
        {
            zarzadzanieHotelemController.DodajPokojDoHotelu(pokoj);
        }

        public void EdytujParametryPokoju(int id, IPokojHotelowyModel pokoj)
        {
            zarzadzanieHotelemController.EdytujParametryPokoju(id, pokoj);
        }

        public IPokojHotelowyModel WyszukajPokoj(int id)
        {
            return zarzadzanieHotelemController.WyszukajPokoj(id);
        }

        public ISalaKonferencyjnaModel WyszukaSalaKonferencyjna(int id)
        {
            return zarzadzanieHotelemController.WyszukaSalaKonferencyjna(id);
        }

        public IDaneHoteloweModel WyszukajHotel(int id)
        {
            return zarzadzanieHotelemController.WyszukajHotel(id);
        }
    }
}
