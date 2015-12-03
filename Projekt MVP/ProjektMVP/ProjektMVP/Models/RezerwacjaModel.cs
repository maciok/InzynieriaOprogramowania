using ProjektMVP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektMVP.DTO;

namespace ProjektMVP.Models
{
    public class RezerwacjaModel : IRezerwacjaModel
    {
        public bool PrzedluzPobyt(RezerwacjaPrzedluzPobytDTO dto)
        {
            var result = SprawdzPrzedluzPobyt(dto);
            if (result == true) {
                // TODO Edytuj w bazie danych
            }

            return result;
        }

        public bool SprawdzPrzedluzPobyt(RezerwacjaPrzedluzPobytDTO dto)
        {
            // TODO Sprawdz w bazie danych
            if (dto.Id == 1) {
                return true;
            }

            return false;
        }
    }
}
