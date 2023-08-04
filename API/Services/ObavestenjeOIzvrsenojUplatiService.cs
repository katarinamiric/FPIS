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
            var radnik = await _radnikRepository.GetRadnik(request.RadnikId);
            var osigKuca = await _osiguravajucaKucaRepository.GetOsiguravajucaKuca(request.OsiguravajucaKucaId);
            var uplatnica = await _uplatnicaRepository.GetUplatica(request.UplatnicaId);

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
            };

            return obavestenjeDto;
        }

        public async Task<bool> UpdateObavestenje(int id, ObavestenjeRequestDto request)
        {
            var postojeceObavestenje = await _obavestenjeRepository.GetObavestenjeOIzvrsenojUplati(id);
            postojeceObavestenje.Datum = request.Datum;
            postojeceObavestenje.SvrhaObavestenja = request.SvrhaObavestenja;
            postojeceObavestenje.IdUplatnice = request.UplatnicaId;
            postojeceObavestenje.IdRadnika = request.RadnikId;
            postojeceObavestenje.IdOsiguravajuceKuce = request.OsiguravajucaKucaId;

            var response = await _obavestenjeRepository.UpdateObavestenje(postojeceObavestenje);

            return response > 0;
        }
    }
}