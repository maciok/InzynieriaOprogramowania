using System.Web.Mvc;
using ProjektMVP.Models.Interfaces;

namespace ProjektMVP.Views.WidokiManageraHotelu
{
    public interface IFormularzEdycjiParametrówHotelu
    {
        ActionResult PokażFormularzEdycjiParametrówHotelu(IDaneHoteloweModel dane);

        ActionResult PokażFormularzOdblokowaniaPokoju(IPokojHotelowyModel dane);

        ActionResult PokażFormularzZablokowaniaPokoju(IPokojHotelowyModel dane);
    }
}
