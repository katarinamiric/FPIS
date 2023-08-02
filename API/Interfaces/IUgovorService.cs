using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Requests;

namespace API.Interfaces
{
    public interface IUgovorService
    {
        Task<List<UgovorDto>> FilterUgovori(UgovorParameters parameters);
    }
}