using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using API.Dtos;
using API.Dtos.Requests;
using API.Entities;
using API.Interfaces;
using API.Responses;
using AutoMapper;

namespace API.Services
{
    public class RacunService : IRacunService
    {
        private readonly IRacunRepository _racunRepository;
        private readonly IMapper _mapper;
        public RacunService(IRacunRepository racunRepository, IMapper mapper)
        {
            _racunRepository = racunRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddRacun(RacunRequestDto request)
        {
            var stavke = request.Stavke;



           var racun = new RacunOsiguranja
                   {
                       PozivNaBroj = request.PozivNaBroj,
                       Datum = request.Datum,
                       BrUgovora = request.BrojUgovora,
                       IdNacinaPlacanja = request.NacinPlacanjaId,
                       SifraRadnika = request.SifraRadnika,
                       Iznos = request.Iznos
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

        public async Task<List<RacunDto>> FilterRacuni()
        {
            var result = await _racunRepository.FilterRacuni();
            var racuniDto = new List<RacunDto>();
            foreach (var racun in result)
            {
                var racunDto = new RacunDto()
                {
                    Id = racun.Id,
                    BrojUgovora = racun.BrUgovora,
                    IdNacinaPlacanja = racun.IdNacinaPlacanja,
                    PozivNaBroj = racun.PozivNaBroj,
                    IdOsigKuce = racun.IdOsigKuce,
                    Iznos = racun.Iznos,
                    Datum = racun.Datum,
                    SifraRadnika = racun.SifraRadnika,
                };
                racuniDto.Add(racunDto);
            }
            return racuniDto;
        }

        public async Task<RacunDto> GetRacun(int id)
        {
            var racun = await _racunRepository.GetRacun(id);
            var racunDto = _mapper.Map<RacunDto>(racun);
            return racunDto;
        }

        public async Task<bool> UpdateRacun(int id, RacunRequestDto request)
        {
            var racunPostojeci = await _racunRepository.GetRacun(id);
           var racun = new RacunOsiguranja
                   {
                       PozivNaBroj = request.PozivNaBroj,
                       BrUgovora = request.BrojUgovora,
                       IdNacinaPlacanja = request.NacinPlacanjaId,
                       SifraRadnika = request.SifraRadnika,
                       Iznos = request.Iznos = request.Iznos
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

           public async Task<bool> DeleteAsync(int? id)
            {
                try
                {
                    if (!id.HasValue) throw new Exception("Id ne moze biti prazan");

                    var result = await _racunRepository.DeleteAsync(id.Value);
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Problem sa brisanjem racuna sa id: {id}");
                }
            }

    }
}
