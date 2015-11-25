using System.Collections.Generic;

namespace ProjektMVP.Models.Interfaces
{
    public interface IDaneHoteloweModel
    {
        int HotelId { get; set; }
       
         string Nazwa { get; set; }
         string Adres { get; set; }
         int StarCount { get; set; }
         string Description { get; set; }

         List<IPokojHotelowyModel> PokojHotelowyModels { get; set; }
         List<ISalaKonferencyjnaModel> SaleKonferencyjneModels { get; set; }
    }
}
