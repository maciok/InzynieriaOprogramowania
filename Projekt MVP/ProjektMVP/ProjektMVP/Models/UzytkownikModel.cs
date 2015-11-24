using System.Data.Entity;
using System.Linq;

namespace ProjektMVP.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class UzytkownikModel : IUzytkownikModel
    {
        private static UzytkownikContext db;

        public UzytkownikModel()
        {
            db = new UzytkownikContext();
        }

        #region Robert Witkowski
        //Iteracja 1
        public int ZapiszNowegoUzytkownika(UzytkownikEntity uzytkownik)
        {
            if (WalidujDaneUzytkownika(uzytkownik))
                db.Uzytkownicy.Add(uzytkownik);

            db.SaveChanges();

            return uzytkownik.Id;
        }

        public UzytkownikEntity EdytujNowegoUzytkownika(UzytkownikEntity uzytkownik)
        {
            if (WalidujDaneUzytkownika(uzytkownik))
            {
                var uzytkownikEntity = db.Uzytkownicy.Find(uzytkownik.Id);
                if (uzytkownikEntity == null)
                {
                    throw new Exception("Nie znaleziono użytkownika o podanym ID.");
                }
                uzytkownikEntity.Imie = uzytkownik.Imie;
                uzytkownikEntity.Nazwisko = uzytkownik.Nazwisko;
                uzytkownikEntity.HotelId = uzytkownik.HotelId;
                uzytkownikEntity.PermissionsId = uzytkownik.PermissionsId;
                uzytkownikEntity.KartaKredytowaId = uzytkownik.KartaKredytowaId;
                uzytkownikEntity.Login = uzytkownik.Login;
                db.Entry(uzytkownikEntity).State = EntityState.Modified;
                db.SaveChanges();
                return uzytkownikEntity;
            }
            else
            {
                throw new Exception("Walidacja danych zgłosiła błąd.");
            }
        }

        public bool WalidujDaneUzytkownika(UzytkownikEntity uzytkownik)
        {
            return true;
        }

        //Iteracja 2
        public UzytkownikEntity PobierzUzytkownika(int uzytkownikId)
        {
            return db.Uzytkownicy.Find(uzytkownikId);
        }

        public bool ZawiesUzytkownika(int uzytkownikId)
        {
            return true;
        }

        //Iteracja 3
        public bool WyslijProsbeOUsuniecieKonta(int uzytkownikId, string opis)
        {
            return true;
        }

        #endregion


        public bool EdytujKarteKredytowa(UzytkownikEntity uzytkownik)
        {
            return WalidujDaneKartyKredytowej(uzytkownik);
        }

        public List<UzytkownikEntity> PobierzListeUzytkownikow()
        {
            return new List<UzytkownikEntity>();
        }

        public bool WalidujDaneKartyKredytowej(UzytkownikEntity uzytkownik)
        {
            return true;
        }

        UzytkownikEntity IUzytkownikModel.EdytujKarteKredytowa(UzytkownikEntity uzytkownik)
        {
            throw new NotImplementedException();
        }
    }
}