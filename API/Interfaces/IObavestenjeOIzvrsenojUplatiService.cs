using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Requests;
using API.Responses;

namespace API.Interfaces
{
    public interface IObavestenjeOIzvrsenojUplatiService
    {
        Task<ObavestenjeOIzvrsenojUplatiOsiguranjaDto> GetObavestenjeOIzvrsenojUplati(int id);
        Task<bool> AddObavestenje(ObavestenjeRequestDto request);
        Task<List<ObavestenjeOIzvrsenojUplatiOsiguranjaDto>> GetAllObavestenja();
        Task<bool> UpdateObavestenje(int id, ObavestenjeRequestDto request);
        Task<bool> DeleteAsync(int? id);
    }
}
