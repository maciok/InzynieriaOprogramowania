using ProjektMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjektMVP.Presenters
{
    public interface IZarządzanieHotelem
    {
        ActionResult EdytujParametryHotelu(int hotelId);
        bool ZapiszDaneHotelu(IDaneHoteloweModel data);
    }
}
