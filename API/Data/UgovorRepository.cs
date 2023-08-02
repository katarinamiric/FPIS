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
    public class UgovorRepository : IUgovorRepository
    {
        private readonly ApplicationDbContext _context;

        public UgovorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<UgovorOOsiguranju>> FilterUgovori(Expression<Func<UgovorOOsiguranju, bool>> filter)
        {
            var result = _context.UgovoriOOsiguranju
                .Include(p => p.Drzava)
                .Include(p => p.Radnik)
                .Include(p => p.Zahtev)
                .Where(filter ?? (s => true));

            var data = await result.AsNoTracking().ToListAsync();
            return data;
        }
    }
}