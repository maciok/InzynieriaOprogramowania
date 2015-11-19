using ProjektMVP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVP.Models
{
    public class PlatnosciModel : IPlatnosciModel
    {
        public bool DodajPlatnosc(PlatnoscEntity platnosc)
        {
            throw new NotImplementedException();
        }

        public bool EdytujPlatnosc(PlatnoscEntity platnosc)
        {
            throw new NotImplementedException();
        }

        public bool UsunPlatnosc(int platnoscID)
        {
            throw new NotImplementedException();
        }

        public List<PlatnoscEntity> WyswietlListePlatnosci(int uzytkownikID)
        {
            throw new NotImplementedException();
        }
    }

    public enum PlatnoscFormatZapisu
    {
        FormatTXT
    }

    public class PlatnoscZapiszDoPlikuViewModel
    {
        public PlatnoscEntity Platnosc { get; set; }
        public PlatnoscFormatZapisu Format { get; set; }
    }
}
