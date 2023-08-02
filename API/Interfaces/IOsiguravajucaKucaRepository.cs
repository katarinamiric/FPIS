using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IOsiguravajucaKucaRepository
    {
        Task<List<TProjection>> GetOsiguravajucaKuce<TProjection>(Expression<Func<OsiguravajucaKuca, TProjection>> selector);
        Task<OsiguravajucaKuca> GetOsiguravajucaKuca(int id);
    }
}