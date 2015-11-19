using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVP.Models.Interfaces
{
    public interface IPlatnosciModel
    {
        bool DodajPlatnosc(PlatnoscEntity platnosc);
        bool EdytujPlatnosc(PlatnoscEntity platnosc);
        List<PlatnoscEntity> WyswietlListePlatnosci(int uzytkownikID);
        bool UsunPlatnosc(int platnoscID);
    }
}
