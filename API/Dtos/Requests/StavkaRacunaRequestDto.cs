using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.Requests
{
    public class StavkaRacunaRequestDto
    {
        public string NazivVrsteOsiguranja { get; set; }
        public double Cena { get; set; }
    }
}