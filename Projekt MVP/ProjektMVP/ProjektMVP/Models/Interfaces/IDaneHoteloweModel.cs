using System.Collections.Generic;

namespace ProjektMVP.Models.Interfaces
{
    public interface IDaneHoteloweModel
    {
        int HotelId { get; set; }
        List<IPokojHotelowyModel> PokojHotelowyModels { get; set; }
        List<ISalaKonferencyjnaModel> SaleKonferencyjneModels { get; set; }
    }
}
