using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.Requests;
using API.Entities;
using API.Interfaces;
using API.Responses;

namespace API.Services
{
    public class RacunService : IRacunService
    {
        private readonly IRacunRepository _racunRepository;
        public RacunService(IRacunRepository racunRepository)
        {
            _racunRepository = racunRepository;
        }

        public async Task<bool> AddRacun(RacunRequestDto request)
        {
            var stavke = request.Stavke;



            var racun = new RacunOsiguranja()
            {
                PozivNaBroj = request.PozivNaBroj,
                Datum = request.Datum,
                BrUgovora = request.BrojUgovora,
                IdNacinaPlacanja = request.NacinPlacanjaId,
                SifraRadnika = request.SifraRadnika
            };

            racun.Radnik = _racunRepository.GetRadnik(request.SifraRadnika);
            racun.Ugovor = _racunRepository.GetUgovor(request.BrojUgovora);
            racun.NacinPlacanja = _racunRepository.GetNacinPlacanja(request.NacinPlacanjaId);

            foreach (var stavkaDto in stavke)
            {
                var stavka = new StavkaRacunaOsiguranja()
                {
                    NazivVrsteOsiguranja = stavkaDto.NazivVrsteOsiguranja,
                    Cena = stavkaDto.Cena,
                    RacunOsiguranja = racun
                };

                racun.StavkeRacunaOsiguranja.Add(stavka);
            }

            var response = await _racunRepository.AddRacun(racun);

            return response;
        }

        public async Task<bool> UpdateRacun(int id, RacunRequestDto request)
        {
            var racunPostojeci = _racunRepository.GetRacun(id);
            var racun = new RacunOsiguranja()
            {
                PozivNaBroj = request.PozivNaBroj,
                BrUgovora = request.BrojUgovora,
                IdNacinaPlacanja = request.NacinPlacanjaId,
                SifraRadnika = request.SifraRadnika,
            };

            foreach (var stavkaDto in request.Stavke)
            {
                var stavka = new StavkaRacunaOsiguranja()
                {
                    NazivVrsteOsiguranja = stavkaDto.NazivVrsteOsiguranja,
                    Cena = stavkaDto.Cena,
                    RacunOsiguranja = racun
                };

                racun.StavkeRacunaOsiguranja.Add(stavka);
            }
            var result = await _racunRepository.UpdateRacun(racun, racunPostojeci);
            return result > 0;
        }
    }
}