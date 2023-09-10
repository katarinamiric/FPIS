using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Requests;
using API.Entities;
using API.Interfaces;
using API.Responses;

namespace API.Services
{
    public class UplatnicaZaOsiguranjeService : IUplatnicaZaOsiguranjeService
    {
        private readonly IUplatnicaZaOsiguranjeRepository _uplatnicaZaOsiguranjeRepository;

        public UplatnicaZaOsiguranjeService(IUplatnicaZaOsiguranjeRepository uplatnicaZaOsiguranjeRepository)
        {
            _uplatnicaZaOsiguranjeRepository = uplatnicaZaOsiguranjeRepository;
        }

        public async Task<List<UplatnicaZaOsiguranjeDto>> FilterUplatnice(UplatnicaParameters parameters)
        {
            Expression<Func<UplatnicaZaOsiguranje, bool>> filter = null;
            if (parameters != null)
            {
                filter = p => parameters
                    .SvrhaUplate != null && (p.Id == parameters.Id
                                             || p.SvrhaUplate.Contains(parameters
                                                 .SvrhaUplate) ||
                                             p.Iznos == parameters.Iznos);
            }

            var uplatnice = await _uplatnicaZaOsiguranjeRepository.FilterUplatnice(filter ?? null);
            var uplatniceDto = new List<UplatnicaZaOsiguranjeDto>();
            foreach (var uplatnica in uplatnice)
            {
                var uplatnicaDto = new UplatnicaZaOsiguranjeDto()
                {
                    Id = uplatnica.Id,
                    BrojRacuna = uplatnica.BrojRacuna,
                    Datum = uplatnica.Datum,
                    Iznos = uplatnica.Iznos,
                };
                uplatniceDto.Add(uplatnicaDto);
            }

            return uplatniceDto;
        }
    }
}
