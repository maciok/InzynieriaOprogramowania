using System.Collections.Generic;
using System.Linq;
using ProjektMVP.Models.Interfaces;

namespace ProjektMVP.Models
{
    public class DaneHoteloweModel : IDaneHoteloweModel
    {
        public int HotelId { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public int StarCount { get; set; }
        public string Description { get; set; }

        public List<IPokojHotelowyModel> PokojHotelowyModels { get; set; }
        public List<ISalaKonferencyjnaModel> SaleKonferencyjneModels { get; set; }
       
    }
}
