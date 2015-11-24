using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ProjektMVP.Models.Interfaces;
using ProjektMVP.Models;

namespace ProjektMVP.Controllers
{
    class ZarzadzenieHotelamiController: Controller
    {
        private static ZarzadzanieHotelami zarzadzanieHotelami = new ZarzadzanieHotelami();

        public IDaneHoteloweModel DodajHotel(IDaneHoteloweModel dane)
        {
            zarzadzanieHotelami.DodajHotel(dane);
            return dane;
        }
    }
}
