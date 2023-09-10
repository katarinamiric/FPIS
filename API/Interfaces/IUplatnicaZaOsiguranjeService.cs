using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Requests;
using API.Responses;

namespace API.Interfaces
{
    public interface IUplatnicaZaOsiguranjeService
    {
        Task<List<UplatnicaZaOsiguranjeDto>> FilterUplatnice(UplatnicaParameters parameters = null);
    }
}
