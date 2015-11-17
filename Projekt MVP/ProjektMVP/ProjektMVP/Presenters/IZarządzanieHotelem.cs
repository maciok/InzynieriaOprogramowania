using System.Web.Mvc;
using ProjektMVP.Models.Interfaces;

namespace ProjektMVP.Presenters
{
    public interface IZarządzanieHotelem
    {
        ActionResult EdytujParametryHotelu(int hotelId);
        bool ZapiszDaneHotelu(IDaneHoteloweModel data);
    }
}
