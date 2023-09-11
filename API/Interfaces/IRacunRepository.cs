using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IRacunRepository
    {
        Task<bool> AddRacun(RacunOsiguranja racun);
        NacinPlacanja GetNacinPlacanja(int nacinPlacanjaId);
        Radnik GetRadnik(int radnikId);
        UgovorOOsiguranju? GetUgovor(int? brojUgovora);
        Task<RacunOsiguranja> GetRacun(int id);
        Task<int> UpdateRacun(RacunOsiguranja racun, RacunOsiguranja racunPostojeci);
        Task<List<RacunOsiguranja>> FilterRacuni();
        Task<bool> DeleteAsync(int id);
    }
}
