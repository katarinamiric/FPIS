using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ObavestenjeOIzvrsenojUplatiRepository : IObavestenjeOIzvrsenojUplatiRepository
    {
        private readonly ApplicationDbContext _context;
        public ObavestenjeOIzvrsenojUplatiRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddObavestenje(ObavestenjeOIzvrsenojUplatiOsiguranja obavestenje, CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                await _context.ObavestenjaOIzvrsenojUplatiOsiguranja.AddAsync(obavestenje, cancellationToken);
                var response = await _context.SaveChangesAsync(cancellationToken);
                return response > 0;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<List<ObavestenjeOIzvrsenojUplatiOsiguranja>> getAllObavestenja(CancellationToken cancellationToken = new CancellationToken())
        {
            return await _context.ObavestenjaOIzvrsenojUplatiOsiguranja
                .Include(s => s.Uplatnica)
                .Include(s => s.Radnik)
                .Include(s => s.OsiguravajucaKuca)
                .ToListAsync(cancellationToken);
        }

        public async Task<ObavestenjeOIzvrsenojUplatiOsiguranja> GetObavestenjeOIzvrsenojUplati(int id)
        {
            return await _context.ObavestenjaOIzvrsenojUplatiOsiguranja
            .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<int> UpdateObavestenje(ObavestenjeOIzvrsenojUplatiOsiguranja postojeceObavestenje, CancellationToken cancellationToken = new CancellationToken())
        {
            _context.Entry(postojeceObavestenje).State = EntityState.Modified;

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}