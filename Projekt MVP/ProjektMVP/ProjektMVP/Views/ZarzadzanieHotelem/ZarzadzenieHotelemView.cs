using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektMVP.Models;
using ProjektMVP.Models.Interfaces;
using ProjektMVP.Presenters;

namespace ProjektMVP.Views.ZarzadzanieHotelem
{
    class ZarzadzenieHotelemView
    {
        private static ZarzadzanieHotelemController zarzadzanieHotelemController = new ZarzadzanieHotelemController();

        public IDaneHoteloweModel PobierzHotel(int hotelID)
        {
            return new View(zarzadzanieHotelemController.WyszukajHotel(hotelID));
        }

        public ActionResult EdytujParametryHotelu(int hotelId)
        {
            return new View(zarzadzanieHotelemController.EdytujParametryHotelu(hotelId)); ;
        }

        public bool ZapiszDaneHotelu(IDaneHoteloweModel data)
        {
            return new View(zarzadzanieHotelemController.ZapiszDaneHotelu(data));
        }

        public void DodajPokojDoHotelu(IPokojHotelowyModel pokoj)
        {
            return new View(zarzadzanieHotelemController.DodajPokojDoHotelu(pokoj));
        }

        public void EdytujParametryPokoju(int id, IPokojHotelowyModel pokoj)
        {
            return new View(zarzadzanieHotelemController.EdytujParametryPokoju(id, pokoj));
        }

        public IPokojHotelowyModel WyszukajPokoj(int id)
        {
            return new View(zarzadzanieHotelemController.WyszukajPokoj(id));
        }

        public ISalaKonferencyjnaModel WyszukaSalaKonferencyjna(int id)
        {
            return new View(zarzadzanieHotelemController.WyszukaSalaKonferencyjna(id));
        }

        public IDaneHoteloweModel WyszukajHotel(int id)
        {
            return new View(zarzadzanieHotelemController.WyszukaSalaKonferencyjna(id));
        }
    }
}
