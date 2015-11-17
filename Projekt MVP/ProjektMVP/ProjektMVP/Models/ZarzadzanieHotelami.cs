using ProjektMVP.Models.Interfaces;

namespace ProjektMVP.Models
{
    public class ZarzadzanieHotelami : IZarzadzanieHotelami
    {
        public IDaneHoteloweModel PobierzHotel(int hotelID)
        {
            return new DaneHoteloweModel()
            {
                HotelID = 1
            };
        }

        public bool ZapiszHotel(IDaneHoteloweModel dane)
        {
            return true;
        }
    }
}
