﻿namespace ProjektMVP.Controllers
{
    using Models;
    using Models.Interfaces;
    using System.Web.Mvc;
    using DTO;
    using Interfaces;
    using System.Collections.Generic;
    using Microsoft.Ajax.Utilities;

    [RoutePrefix("users")]
    public class ZarzadzajUzytkownikamiController : Controller, IZarzadzajUzytkownikamiPresenter
    {
        private static IUzytkownikModel uzytkownikModel;

        public ZarzadzajUzytkownikamiController()
        {
            uzytkownikModel = new UzytkownikModel();
        }

        #region Robert Witkowski
        //Iteracja 1
        [Route("formularz")]
        [HttpGet]
        public ActionResult WyswietlFormularzDodawaniaLubEdytowaniaUzytkownika(UzytkownikDTO dto)
        {
            return View("FormularzDodawaniaLubEdytowaniaUzytkownika");
        }

        [Route("formularz")]
        [HttpPost]
        public ActionResult DodajLubEdytujUzytkownik(UzytkownikDTO dto)
        {
            if (dto.Id.HasValue)
            {
                var newDto = EdytujUzytkownika(dto);
                ViewBag.Message = "Użytkownik został edytowany."; 
                return View("FormularzDodawaniaLubEdytowaniaUzytkownika", newDto);
            }
            else
            {
                dto.Id = DodajUzytkownika(dto);
                ViewBag.Message = "Nowy użytkownik został dodany.";
                ModelState.Clear();
                return View("FormularzDodawaniaLubEdytowaniaUzytkownika", dto);
            }
        }

        public int DodajUzytkownika(UzytkownikDTO dto)
        {
            return uzytkownikModel.ZapiszNowegoUzytkownika(UzytkownikMapper.MapDtoToEntity(dto));
        }

        public UzytkownikDTO EdytujUzytkownika(UzytkownikDTO dto)
        {
            var edytowanyUzytkownik = uzytkownikModel.EdytujNowegoUzytkownika(UzytkownikMapper.MapDtoToEntity(dto));
            return UzytkownikMapper.MapEntityToDto(edytowanyUzytkownik);
        }

        //Iteracja 2
        [Route("mojekonto/{uzytkownikId:int}")]
        [HttpGet]
        public ActionResult WyswietlInformacjeOKoncie(int uzytkownikId)
        {
            var uzytkownik = PobierzUzytkownika(uzytkownikId);
            return View("InformacjeOKoncie", uzytkownik);
        }

        [Route("zawies/{uzytkownikId}")]
        [HttpGet]
        public ActionResult ZawiesUzytkownikaButton(int uzytkownikId)
        {

            var uzytkownik = PobierzUzytkownika(uzytkownikId);
            return View("InformacjeOKoncie", uzytkownik);
        }

        public UzytkownikDTO PobierzUzytkownika(int uzytkownikId)
        {
            var uzytkownik = uzytkownikModel.PobierzUzytkownika(uzytkownikId);
            return UzytkownikMapper.MapEntityToDto(uzytkownik);
        }

        public bool ZawiesUzytkownika(int uzytkownikId)
        {
            return uzytkownikModel.ZawiesUzytkownika(uzytkownikId);
        }

        //Iteracja 3
        [Route("usunieciekonta/{uzytkownikId}/{opis}")]
        [HttpGet]
        [HttpPost]
        public ActionResult WyswietlFormularzProsbyOUsuniecieKonta(int uzytkownikId, string opis)
        {
            if (opis.IsNullOrWhiteSpace())
                return View("FormularzProsbyOUsuniecieKonta", uzytkownikId);
            else
            {
                WyslijProsbeOUsuniecieKonta(uzytkownikId, opis);
                return View("Index");
            }
        }

        public bool WyslijProsbeOUsuniecieKonta(int uzytkownikId, string opis)
        {
            return uzytkownikModel.WyslijProsbeOUsuniecieKonta(uzytkownikId, opis);
        }
        #endregion

        public UzytkownikDTO EdytujKarteKredytowa(UzytkownikDTO u)
        {
            var edytowanyUzytkownik = uzytkownikModel.EdytujKarteKredytowa(UzytkownikMapper.MapDtoToEntity(u));
            return UzytkownikMapper.MapEntityToDto(edytowanyUzytkownik);
        }

        public List<UzytkownikDTO> WezListeUzytkownikow()
        {
            List<UzytkownikDTO> tmp = new List<UzytkownikDTO>();

            foreach (var uzytkownik in uzytkownikModel.PobierzListeUzytkownikow())
                tmp.Add(UzytkownikMapper.MapEntityToDto(uzytkownik));

            return tmp;
        }
    }
}