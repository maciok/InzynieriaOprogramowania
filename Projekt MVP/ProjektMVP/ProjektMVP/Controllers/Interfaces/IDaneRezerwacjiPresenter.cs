﻿using ProjektMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjektMVP.Controllers.Interfaces
{
    public interface IDaneRezerwacjiPresenter
    {
        bool ZaksiegujPlatnosc(PlatnoscEntity platnosc);
        string ZapiszDoPliku(PlatnoscEntity platnosc, PlatnoscFormatZapisu format);
        string FormatTxt(PlatnoscEntity platnosc);
        void Drukuj(PlatnoscEntity platnosc);
    }
}
