using ProjektMVP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVP.Models.Interfaces
{
    public interface IRezerwacjaModel
    {
        bool SprawdzPrzedluzPobyt(RezerwacjaPrzedluzPobytDTO dto);
        bool PrzedluzPobyt(RezerwacjaPrzedluzPobytDTO dto);
    }
}
