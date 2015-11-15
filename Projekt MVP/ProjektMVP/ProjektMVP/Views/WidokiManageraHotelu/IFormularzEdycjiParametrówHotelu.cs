using ProjektMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjektMVP.Views.WidokiManageraHotelu
{
    public interface IFormularzEdycjiParametrówHotelu
    {
        ActionResult PokażFormularzEdycjiParametrówHotelu(IDaneHoteloweModel dane);
    }
}
