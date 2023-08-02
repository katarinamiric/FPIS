using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IObavestenjeOIzvrsenojUplatiRepository
    {
        Task<ObavestenjeOIzvrsenojUplatiOsiguranja> GetObavestenjeOIzvrsenojUplati(int id);
        Task<bool> AddObavestenje(ObavestenjeOIzvrsenojUplatiOsiguranja obavestenje, CancellationToken cancellationToken = new CancellationToken());
        Task<List<ObavestenjeOIzvrsenojUplatiOsiguranja>> getAllObavestenja(CancellationToken cancellationToken = new CancellationToken());
        Task<int> UpdateObavestenje(ObavestenjeOIzvrsenojUplatiOsiguranja postojeceObavestenje, CancellationToken cancellationToken = new CancellationToken());
    }
}