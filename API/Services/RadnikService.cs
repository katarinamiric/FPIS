using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Interfaces;

namespace API.Services
{
    public class RadnikService : IRadnikService
    {
        private readonly IRadnikRepository _radnikRepository;

        public RadnikService(IRadnikRepository radnikRepository)
        {
            _radnikRepository = radnikRepository;
        }

        public async Task<List<RadnikDto>> GetRadnici()
        {
            var radnici = await _radnikRepository.GetRadnici(s => new RadnikDto{
                Name = s.ImePrezime,
                Id = s.Id,
            });

            return radnici;
        }
    }
}