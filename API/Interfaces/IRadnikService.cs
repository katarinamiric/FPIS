using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;

namespace API.Interfaces
{
    public interface IRadnikService
    {
        Task<List<RadnikDto>> GetRadnici();
    }
}