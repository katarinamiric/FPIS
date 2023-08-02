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
    public class UplatnicaZaOsiguranjeRepository : IUplatnicaZaOsiguranjeRepository
    {
        private readonly ApplicationDbContext _context;

        public UplatnicaZaOsiguranjeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<UplatnicaZaOsiguranje>> FilterUplatnice(Expression<Func<UplatnicaZaOsiguranje, bool>> filter)
        {
            var result = _context.UplatniceZaOsiguranje
                .AsNoTracking()
                .Where(filter ?? (s => true));
            
            var data = await result.ToListAsync();
            return data;
        }

        public async Task<UplatnicaZaOsiguranje> GetUplatica(int id) => await _context.UplatniceZaOsiguranje
                .FirstOrDefaultAsync(s => s.Id == id);
    }
}