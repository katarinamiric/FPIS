using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class RadnikRepository : IRadnikRepository
    {
        private readonly ApplicationDbContext _context;
        public RadnikRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TProjection>> GetRadnici<TProjection>(Expression<Func<Radnik, TProjection>> selector)
        {
            try
            {
                return await _context.Radnici
                    .AsNoTracking()
                    .Select(selector)
                    .ToListAsync();
            }
            catch (System.Exception e)
            {
                throw;
            }
        }

        public async Task<Radnik> GetRadnik(int id)
        {
            return await _context.Radnici
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<TProjection>> GetNaciniPlacanja<TProjection>(Expression<Func<NacinPlacanja, TProjection>> selector)
        {
            try
            {
                return await _context.NaciniPlacanja
                    .AsNoTracking()
                    .Select(selector)
                    .ToListAsync();
            }
            catch (System.Exception e)
            {
                throw;
            }
        }
    }
}
