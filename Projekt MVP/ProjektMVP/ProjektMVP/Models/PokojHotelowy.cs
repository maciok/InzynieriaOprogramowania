using ProjektMVP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMVP.Models
{
    public class PokojHotelowy : IPokojHotelowyModel
    {
        public int PokojHotelowyId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int Standard { get; set; }
        public StatusPokoju Status { get; set; }
    }
}
