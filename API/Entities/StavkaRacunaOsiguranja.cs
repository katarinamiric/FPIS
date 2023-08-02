using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class StavkaRacunaOsiguranja
    {
        public int Id { get; set; }
        public string NazivVrsteOsiguranja { get; set; }
        public double Cena { get; set; }
        public int IdRacunaOsiguranja { get; set; }
        public virtual RacunOsiguranja RacunOsiguranja { get; set; }
    }
}