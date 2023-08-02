using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Responses
{
    public class RacunResponseDto
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public double Iznos { get; set; }
        public string PozivNaBroj { get; set; }
        public int BrUgovora { get; set; }
    }
}