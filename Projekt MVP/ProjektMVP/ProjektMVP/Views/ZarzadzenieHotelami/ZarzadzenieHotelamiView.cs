using ProjektMVP.Models.Interfaces;
using ProjektMVP.Controllers;

namespace ProjektMVP.Views.ZarzadzenieHotelami
{
    class ZarzadzenieHotelamiView
    {
        private ZarzadzenieHotelamiController zarzadzenieHotelamiController = new ZarzadzenieHotelamiController();


        public IDaneHoteloweModel DodajHotel(IDaneHoteloweModel daneHotelowe)
        {
            return zarzadzenieHotelamiController.DodajHotel(daneHotelowe);
        }

    }
}
