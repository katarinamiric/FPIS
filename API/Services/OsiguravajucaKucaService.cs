using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Interfaces;

namespace API.Services
{
    public class OsiguravajucaKucaService : IOsiguravajucaKucaService
    {
        private readonly IOsiguravajucaKucaRepository _osiguravajucaKucaRepository;

        public OsiguravajucaKucaService(IOsiguravajucaKucaRepository osiguravajucaKucaRepository)
        {
            _osiguravajucaKucaRepository = osiguravajucaKucaRepository;
        }

        public Task<List<OsiguravajucaKucaDto>> GetOsiguravajuceKuce()
        {
            return _osiguravajucaKucaRepository.GetOsiguravajucaKuce(s => new OsiguravajucaKucaDto{
                Id = s.Id,
                Name = s.NazivOsigurava
            });
        }
    }
}