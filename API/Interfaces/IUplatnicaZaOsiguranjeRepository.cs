using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IUplatnicaZaOsiguranjeRepository
    {
        Task<List<UplatnicaZaOsiguranje>> FilterUplatnice(Expression<Func<UplatnicaZaOsiguranje, bool>>? filter = null);
        Task<UplatnicaZaOsiguranje> GetUplatica(int id);
    }
}
