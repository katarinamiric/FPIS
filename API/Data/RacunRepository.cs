using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class RacunRepository : IRacunRepository
    {
        private readonly ApplicationDbContext _context;
        public RacunRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddRacun(RacunOsiguranja racun)
        {
            try
            {
                await _context.RacuniOsiguranja.AddAsync(racun);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            catch (System.Exception e)
            {
                return false;
                throw;
            }
        }

        public async Task<List<RacunOsiguranja>> FilterRacuni()
        {
            var result = await _context.RacuniOsiguranja.ToListAsync();
            return result;
        }

        public NacinPlacanja GetNacinPlacanja(int nacinPlacanjaId) => _context.NaciniPlacanja.Find(nacinPlacanjaId);


        public async Task<RacunOsiguranja> GetRacun(int id)
        {
            return await _context.RacuniOsiguranja
                 .Include(x => x.OsiguravajucaKuca)
                  .Include(x => x.Ugovor)
                    .Include(x => x.Radnik)
                    .Include(x => x.NacinPlacanja)
            .Include(x => x.StavkeRacunaOsiguranja)
            .FirstOrDefaultAsync(r => r.Id == id);
        }

        public Radnik GetRadnik(int radnikId) => _context.Radnici.Find(radnikId);

        public UgovorOOsiguranju? GetUgovor(int? brojUgovora)
        {
            if (!brojUgovora.HasValue) return null;
            return _context.UgovoriOOsiguranju.Find(brojUgovora);
        }

        public async Task<int> UpdateRacun(RacunOsiguranja racun, RacunOsiguranja racunPostojeci)
        {
            racun.Id = racunPostojeci.Id;
            _context.Entry(racunPostojeci).CurrentValues.SetValues(racun);
            _context.Entry(racunPostojeci).Property(p => p.Id).IsModified = false;
            // _context.Entry(racunPostojeci.StavkeRacunaOsiguranja).Property(p => p.Id).IsModified = false;
            var response = await _context.SaveChangesAsync();
            return response;
        }


    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            var racun = await _context.RacuniOsiguranja.FirstOrDefaultAsync(c => c.Id == id);
            if (racun == null) return false;

            _context.RacuniOsiguranja.Remove(racun);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    }
}
