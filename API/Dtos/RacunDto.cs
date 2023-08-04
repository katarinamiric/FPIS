using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class RacunDto
    {
        public int Id { get; set; }
        public string PozivNaBroj { get; set; }
        public DateTime Datum { get; set; }
        public double Iznos { get; set; }
        public int? BrojUgovora { get; set; }
        public int? IdNacinaPlacanja { get; set; }
        public int? IdOsigKuce { get; set; }
        public int SifraRadnika { get; set; }
        public List<StavkaRacunaDto> Stavke { get; set; }
    }
}