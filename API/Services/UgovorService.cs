using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Requests;
using API.Entities;
using API.Interfaces;

namespace API.Services
{
    public class UgovorService : IUgovorService
    {
        private readonly IUgovorRepository _ugovorRepository;

        public UgovorService(IUgovorRepository ugovorRepository)
        {
            _ugovorRepository = ugovorRepository;
        }

        public async Task<List<UgovorDto>> FilterUgovori(UgovorParameters parameters)
        {
            // Expression<Func<UgovorOOsiguranju, bool>> filter = p => (p.Id == parameters.BrojUgovora
            //     || DateTime.Compare(parameters.Datum, p.Datum) == 0);
            var ugovori = await _ugovorRepository.FilterUgovori();
            var ugovoriDto = new List<UgovorDto>();
            foreach (var ugovor in ugovori)
            {
                var ugovorDto = new UgovorDto()
                {
                    Id = ugovor.Id,
                    IdDrzave = ugovor.Drzava?.Id,
                    SifraZahteva = ugovor.Zahtev?.Id,
                    SifraRadnika = ugovor.Radnik?.Id,
                    Potpisao = ugovor.Potpisao,
                    Datum = ugovor.Datum
                };

                ugovoriDto.Add(ugovorDto);
            }

            return ugovoriDto;
        }
    }
}