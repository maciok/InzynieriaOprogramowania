using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVP.Models
{
    public interface IZarzadzanieHotelami 
    {
        IDaneHoteloweModel PobierzHotel(int hotelID);

        bool ZapiszHotel(IDaneHoteloweModel dane);
    }
}
