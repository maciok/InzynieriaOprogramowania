using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVP.Models.Interfaces
{
    public enum StatusPokoju
    {
        Odblokowany,
        Zablokowany
    }

    public interface IPokojHotelowyModel
    {
        int PokojHotelowyId { get; set; }
        string Nazwa { get; set; }
        string Opis { get; set; }
        int Standard { get; set; }

        StatusPokoju Status { get; set; }
    }
}
