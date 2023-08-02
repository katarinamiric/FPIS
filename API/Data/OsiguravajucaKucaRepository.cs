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
    public class OsiguravajucaKucaRepository : IOsiguravajucaKucaRepository
    {
        private readonly ApplicationDbContext _context;
        public OsiguravajucaKucaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OsiguravajucaKuca> GetOsiguravajucaKuca(int id) => await _context.OsiguravajuceKuce
                .FirstOrDefaultAsync(s => s.Id == id);

        public async Task<List<TProjection>> GetOsiguravajucaKuce<TProjection>(Expression<Func<OsiguravajucaKuca, TProjection>> selector)
        {
            try
            {
                return await _context.OsiguravajuceKuce
                    .AsNoTracking()
                    .Select(selector)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                throw;
            }
            
        }
    }
}