namespace ProjektMVP.Models.Interfaces
{
    public interface IZarzadzanieHotelami 
    {
        IDaneHoteloweModel PobierzHotel(int hotelID);

        bool ZapiszHotel(IDaneHoteloweModel dane);
    }
}
