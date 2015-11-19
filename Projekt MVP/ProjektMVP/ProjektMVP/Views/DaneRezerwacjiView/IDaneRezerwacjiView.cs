using ProjektMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjektMVP.Views.DaneRezerwacjiView
{
    public interface IDaneRezerwacjiView
    {
        ActionResult KliknijWygenerujRachunek(RezerwacjaEntity rezerwacja);
        ActionResult KliknijZapiszPlatnosc(PlatnoscEntity platnosc);
        ActionResult KliknijZaksiegujPlatnosc(PlatnoscEntity platnosc);
        ActionResult KliknijZapiszDoPliku(PlatnoscZapiszDoPlikuViewModel input);
    }
}
