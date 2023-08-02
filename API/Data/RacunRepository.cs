using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;

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

        public NacinPlacanja GetNacinPlacanja(int nacinPlacanjaId) => _context.NaciniPlacanja.Find(nacinPlacanjaId);

        public RacunOsiguranja GetRacun(int id)
        {
            var result = _context.RacuniOsiguranja
                .FirstOrDefault(p => p.Id == id);
            return result;
        }

        public Radnik GetRadnik(int radnikId) => _context.Radnici.Find(radnikId);

        public UgovorOOsiguranju GetUgovor(int brojUgovora) => _context.UgovoriOOsiguranju.Find(brojUgovora);

        public async Task<int> UpdateRacun(RacunOsiguranja racun, RacunOsiguranja racunPostojeci)
        {
            racun.Id = racunPostojeci.Id;
            _context.Entry(racunPostojeci).CurrentValues.SetValues(racun);
            _context.Entry(racunPostojeci).Property(p => p.Id).IsModified = false;
            // _context.Entry(racunPostojeci.StavkeRacunaOsiguranja).Property(p => p.Id).IsModified = false;
            var response = await _context.SaveChangesAsync();
            return response;
        }
    }
}