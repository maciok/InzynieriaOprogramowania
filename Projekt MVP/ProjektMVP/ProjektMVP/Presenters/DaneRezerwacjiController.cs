using ProjektMVP.Presenters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ProjektMVP.Models;
using ProjektMVP.Models.Interfaces;

namespace ProjektMVP.Presenters
{
#pragma warning disable CS0162 // Unreachable code detected

    public class DaneRezerwacjiController : Controller, IDaneRezerwacjiPresenter
    {
        private static IPlatnosciModel _platnosc;

        public DaneRezerwacjiController()
        {
            _platnosc = new PlatnosciModel();
        }

        public bool ZaksiegujPlatnosc(PlatnoscEntity platnosc)
        {
            throw new NotImplementedException();

            _platnosc.DodajPlatnosc(platnosc);
            return true;
        }

        public string ZapiszDoPliku(PlatnoscEntity platnosc, PlatnoscFormatZapisu format)
        {
            throw new NotImplementedException();

            // Utworz dokument ze wzgledu na format
            if (format == PlatnoscFormatZapisu.FormatTXT) {
                var document = FormatTxt(platnosc);
            } else {
                // inne formaty
            }

            // String bedzie zastapiony typem File w przyszlosci
            return "File()";
        }

        public string FormatTxt(PlatnoscEntity platnosc)
        {
            throw new NotImplementedException();
        }

        public void Drukuj(PlatnoscEntity platnosc)
        {
            //drukowanie...
        }
    }
#pragma warning restore CS0162 // Unreachable code detected
}
