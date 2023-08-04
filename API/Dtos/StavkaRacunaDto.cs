using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class StavkaRacunaDto
    {
        public int Id { get; set; }
        public string NazivVrsteOsiguranja { get; set; }
        public double Cena { get; set; }
    }
}