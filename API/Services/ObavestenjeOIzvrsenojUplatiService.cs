using API.Dtos;
using API.Dtos.Requests;
using API.Entities;
using API.Interfaces;
using API.Responses;

namespace API.Services
{
    public class ObavestenjeOIzvrsenojUplatiService : IObavestenjeOIzvrsenojUplatiService
    {
        private readonly IObavestenjeOIzvrsenojUplatiRepository _obavestenjeRepository;
        private readonly IRadnikRepository _radnikRepository;
        private readonly IOsiguravajucaKucaRepository _osiguravajucaKucaRepository;
        private readonly IUplatnicaZaOsiguranjeRepository _uplatnicaRepository;
        public ObavestenjeOIzvrsenojUplatiService(IObavestenjeOIzvrsenojUplatiRepository obavestenjeRepository, IRadnikRepository radnikRepository, IOsiguravajucaKucaRepository osiguravajucaKucaRepository, IUplatnicaZaOsiguranjeRepository uplatnicaRepository)
        {
            _obavestenjeRepository = obavestenjeRepository;
            _radnikRepository = radnikRepository;
            _osiguravajucaKucaRepository = osiguravajucaKucaRepository;
            _uplatnicaRepository = uplatnicaRepository;
        }

        public async Task<bool> AddObavestenje(ObavestenjeRequestDto request)
        {
            var radnik = await _radnikRepository.GetRadnik(request.SifraRadnika);
            var osigKuca = await _osiguravajucaKucaRepository.GetOsiguravajucaKuca(request.IdOsigKuce);
            var uplatnica = await _uplatnicaRepository.GetUplatica(request.IdUplatnice);

            var obavestenje = new ObavestenjeOIzvrsenojUplatiOsiguranja()
            {
                OsiguravajucaKuca = osigKuca,
                Radnik = radnik,
                Uplatnica = uplatnica,
                Datum = request.Datum,
                SvrhaObavestenja = request.SvrhaObavestenja
            };

            var result = await _obavestenjeRepository.AddObavestenje(obavestenje);
            return result;
        }

        public async Task<List<ObavestenjeOIzvrsenojUplatiOsiguranjaDto>> GetAllObavestenja()
        {
            var obavestenja = await _obavestenjeRepository.getAllObavestenja();
            var obavestenjaDto = new List<ObavestenjeOIzvrsenojUplatiOsiguranjaDto>();
            foreach (var obavestenje in obavestenja)
            {
                var obavestenjeDto = new ObavestenjeOIzvrsenojUplatiOsiguranjaDto()
                {
                    SvrhaObavestenja = obavestenje.SvrhaObavestenja,
                    Datum = obavestenje.Datum,
                    IdUplatnice = obavestenje.Uplatnica.Id,
                    IdOsigKuce = obavestenje.OsiguravajucaKuca.Id,
                    SifraRadnika = obavestenje.Radnik.Id,
                    Id = obavestenje.Id
                };

                obavestenjaDto.Add(obavestenjeDto);
            }
            return obavestenjaDto;
        }


        public async Task<ObavestenjeOIzvrsenojUplatiOsiguranjaDto> GetObavestenjeOIzvrsenojUplati(int id)
        {
            var obavestenje = await _obavestenjeRepository.GetObavestenjeOIzvrsenojUplati(id);
            if(obavestenje == null){
                throw new Exception($"Ne postoji obavestenje sa Id: {id}");
            }
            var obavestenjeDto = new ObavestenjeOIzvrsenojUplatiOsiguranjaDto()
            {
                Id = obavestenje.Id,
                SvrhaObavestenja = obavestenje.SvrhaObavestenja,
                Datum = obavestenje.Datum,
                OsiguravajucaKuca = new OsiguravajucaKucaDto()
                {
                    Id = obavestenje.OsiguravajucaKuca.Id,
                    Name = obavestenje.OsiguravajucaKuca.NazivOsigurava
                },
                Radnik = new RadnikDto()
                {
                    Id = obavestenje.Radnik.Id,
                    Name = obavestenje.Radnik.ImePrezime
                }
            };

            return obavestenjeDto;
        }

        public async Task<bool> UpdateObavestenje(int id, ObavestenjeRequestDto request)
        {
            var postojeceObavestenje = await _obavestenjeRepository.GetObavestenjeOIzvrsenojUplati(id);
            postojeceObavestenje.Datum = request.Datum;
            postojeceObavestenje.SvrhaObavestenja = request.SvrhaObavestenja;
            postojeceObavestenje.IdUplatnice = request.IdUplatnice;
            postojeceObavestenje.IdRadnika = request.SifraRadnika;
            postojeceObavestenje.IdOsiguravajuceKuce = request.IdOsigKuce;

            var response = await _obavestenjeRepository.UpdateObavestenje(postojeceObavestenje);

            return response > 0;
        }

        public async Task<bool> DeleteAsync(int? id)
                {
                    try
                    {
                        if (!id.HasValue)
                        {
                            throw new Exception($"Id ne moze biti prazan");
                        }

                        var result = await _obavestenjeRepository.DeleteAsync(id.Value);
                        return result;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Problem sa brisanjem obavestenja sa id: {id}");
                    }
                }


    }
}
