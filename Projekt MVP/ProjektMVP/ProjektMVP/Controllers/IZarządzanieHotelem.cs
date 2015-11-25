using System.Web.Mvc;
using ProjektMVP.Models.Interfaces;

namespace ProjektMVP.Controllers
{
    public interface IZarządzanieHotelem
    {
        ActionResult EdytujParametryHotelu(int hotelId);
        bool ZapiszDaneHotelu(IDaneHoteloweModel data);
        void DodajPokojDoHotelu(IPokojHotelowyModel pokoj);
        void EdytujParametryPokoju(int id, IPokojHotelowyModel pokoj);
        IPokojHotelowyModel WyszukajPokoj(int id);
        ISalaKonferencyjnaModel WyszukaSalaKonferencyjna(int id);
        IDaneHoteloweModel WyszukajHotel(int id);
        void DodajHotel(IDaneHoteloweModel daneHotelowe);
        bool ZapiszPokoj(IPokojHotelowyModel pokoj);
    }
}
