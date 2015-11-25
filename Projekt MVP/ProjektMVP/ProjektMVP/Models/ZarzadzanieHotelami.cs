using ProjektMVP.DTO;
using ProjektMVP.Models.Interfaces;
using System;

namespace ProjektMVP.Models
{
    public class ZarzadzanieHotelami : IZarzadzanieHotelami
    {
        private DaneHoteloweDB db;
        public IDaneHoteloweModel PobierzHotel(int hotelID)
        {
            Random r = new Random();
            return new DaneHoteloweModel()
            {
                HotelId = r.Next(),
                Nazwa = "Hotel na uboczu",
                Adres = "Warszawa ul. Chopina 321",
                Description = "Super Hotel",
                StarCount = 5,
                SaleKonferencyjneModels = new System.Collections.Generic.List<ISalaKonferencyjnaModel>()
                {
                    new SalaKonferencyjna(){
                        Nazwa = "Aula 1",
                        Opis = "Duża aula",
                        LiczbaMiejsc = 500
                    },
                      new SalaKonferencyjna(){
                        Nazwa = "Aula 2",
                        Opis = "Mała aula",
                        LiczbaMiejsc = 200
                    },
                },
                PokojHotelowyModels = new System.Collections.Generic.List<IPokojHotelowyModel>()
                {
                    new PokojHotelowy()
                    {
                        PokojHotelowyId = 1,
                        Nazwa = "Pokój 1",
                        Opis = "Apartament 1 ",
                        Standard = 1
                    }, new PokojHotelowy()
                    {
                        PokojHotelowyId = 2,
                        Nazwa = "Pokój 2",
                        Opis = "Apartament 2 ",
                        Standard = 1
                    }, new PokojHotelowy()
                    {
                        PokojHotelowyId = 3,
                        Nazwa = "Pokój 3",
                        Opis = "Apartament 3 ",
                        Standard = 1
                    }, new PokojHotelowy()
                    {
                        PokojHotelowyId = 4,
                        Nazwa = "Pokój 3",
                        Opis = "Apartament 3 ",
                        Standard = 4
                    },
                }
                
            };
        }

        public IDaneHoteloweModel DodajHotel(IDaneHoteloweModel daneHotelowe)
        {
            db.DaneHotelowe.Add(daneHotelowe);
            return daneHotelowe;
        }

        public bool ZapiszHotel(IDaneHoteloweModel dane)
        {
            return true;
        }

        public IPokojHotelowyModel PobierzPokoj(int pokojID)
        {
            StatusPokoju status = (pokojID % 2 == 0 ? StatusPokoju.Odblokowany : StatusPokoju.Zablokowany);
            return new PokojHotelowy()
            {
                PokojHotelowyId = pokojID,
                Nazwa = "Pokoj",
                Opis = "Dobry pokój",
                Standard = 1,
                Status = status
            };
        }

        public bool ZapiszPokoj(IPokojHotelowyModel pokoj)
        {
            return true;
        }
    }
}
