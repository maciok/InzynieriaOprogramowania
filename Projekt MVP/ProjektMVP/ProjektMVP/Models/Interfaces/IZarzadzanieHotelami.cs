﻿namespace ProjektMVP.Models.Interfaces
{
    public interface IZarzadzanieHotelami 
    {
        IDaneHoteloweModel PobierzHotel(int hotelID);
        IDaneHoteloweModel DodajHotel(IDaneHoteloweModel daneHotelowe);
        bool ZapiszHotel(IDaneHoteloweModel dane);
        IPokojHotelowyModel PobierzPokoj(int pokojID);
        bool ZapiszPokoj(IPokojHotelowyModel pokoj);
    }
}
