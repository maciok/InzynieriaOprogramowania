using ProjektMVP.DTO;
using ProjektMVP.Models.Interfaces;

namespace ProjektMVP.Models
{
    public class ZarzadzanieHotelami : IZarzadzanieHotelami
    {
        private DaneHoteloweDB db;
        public IDaneHoteloweModel PobierzHotel(int hotelID)
        {
            return new DaneHoteloweModel()
            {
                HotelId = 1
            };
        }

        public IDaneHoteloweModel DodajHotel(IDaneHoteloweModel daneHotelowe)
        {
            db.DaneHotelowe.Add(daneHotelowe);
            return daneHotelowe;
        }

        public bool ZapiszHotel(IDaneHoteloweModel dane)
        {
            return true;
        }
    }
}
