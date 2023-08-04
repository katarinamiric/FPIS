using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Requests;
using API.Responses;

namespace API.Interfaces
{
    public interface IRacunService
    {
        Task<List<RacunDto>> FilterRacuni();
        Task<bool> AddRacun(RacunRequestDto request);
        Task<bool> UpdateRacun(int id, RacunRequestDto request);
        Task<RacunDto> GetRacun(int id);
    }
}