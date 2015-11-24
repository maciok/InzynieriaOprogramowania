using System.Collections.Generic;
using System.Linq;
using ProjektMVP.Models.Interfaces;

namespace ProjektMVP.Models
{
    public class DaneHoteloweModel : IDaneHoteloweModel
    {
        public int HotelId { get; set; }
        public List<IPokojHotelowyModel> PokojHotelowyModels { get; set; }
        public List<ISalaKonferencyjnaModel> SaleKonferencyjneModels { get; set; }
        public List<IPokojHotelowyModel> _pokojHotelowyModels;
        public List<ISalaKonferencyjnaModel> _saleKonferencyjneModels;
       
    }
}
