using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
