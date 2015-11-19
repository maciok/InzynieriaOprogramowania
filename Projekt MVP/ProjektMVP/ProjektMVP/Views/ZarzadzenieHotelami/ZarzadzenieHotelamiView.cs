using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektMVP.Models.Interfaces;
using ProjektMVP.Presenters;

namespace ProjektMVP.Views.ZarzadzenieHotelami
{
    class ZarzadzenieHotelamiView
    {
        private ZarzadzenieHotelamiController zarzadzenieHotelamiController = new ZarzadzenieHotelamiController();


        public IDaneHoteloweModel DodajHotel(IDaneHoteloweModel daneHotelowe)
        {
            return View(zarzadzenieHotelamiController.DodajHotel(daneHotelowe));
        }

    }
}
