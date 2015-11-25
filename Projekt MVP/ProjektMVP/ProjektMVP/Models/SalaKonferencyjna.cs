using ProjektMVP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVP.Models
{
    public class SalaKonferencyjna : ISalaKonferencyjnaModel
    {
        public int SalaKonferencyjnaId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int LiczbaMiejsc { get; set; }


    }
}