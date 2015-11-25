using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVP.Models.Interfaces
{
    public interface ISalaKonferencyjnaModel
    {
        int SalaKonferencyjnaId { get; set; }

         string Nazwa { get; set; }
         string Opis { get; set; }
         int LiczbaMiejsc { get; set; }
    }
}
